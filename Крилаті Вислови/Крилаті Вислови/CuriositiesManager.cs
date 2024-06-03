using System;
using System.Collections.Generic;
using System.Runtime.Remoting.Messaging;
using System.IO;
using System.Text.RegularExpressions;
using System.Linq;

public class Curiosity
{
	public int Id {  get; set; }
	public string Text { get; set; }
	public string Type { get; set; }
	public string Author { get; set; }
    public bool IsFavorite { get; set; }
    public Curiosity(int id, string text, string type, string author, bool isFavorite)
	{
		Id = id;
		Text = text;
		Type = type;
		Author = author;
        IsFavorite = isFavorite;
    }
}

public class CuriositiesManager
{
    private string filepath;
    private List<Curiosity> curiosities;
    private ActionHistory actionHistory;
    private bool hasChanges = false;
    public CuriositiesManager(string path, string historyPath)
	{
		filepath = path;
		curiosities = new List<Curiosity>();
        actionHistory = new ActionHistory(historyPath);
        Load();
    }
    public ActionHistory ActionHistory => actionHistory;
    public void Add(Curiosity curiosity)
    {
        curiosity.Id = curiosities.Count > 0 ? curiosities.Max(c => c.Id) + 1 : 1;
        curiosities.Add(curiosity);
        hasChanges = true;
    }
    public void Remove(int id)
    {
        var curiosity = GetCuriosityById(id);
        if (curiosity != null)
        {
            curiosities.Remove(curiosity);
            hasChanges = true;
        }
    }
    private void Load()
    {
        List<string> updatedLines = new List<string>();
        curiosities.Clear();
        HashSet<int> existingIds = new HashSet<int>();
        int nextId = 1;
        if (File.Exists(filepath))
        {
            string[] lines = File.ReadAllLines(filepath);
            for (int i = 0; i < lines.Length; i++)
            {
                string[] parts = lines[i].Split('|');
                if (parts.Length == 5)
                {
                    if (int.TryParse(parts[0], out int id))
                    {
                        if (existingIds.Contains(id))
                        {
                            while (existingIds.Contains(nextId))
                            {
                                nextId++;
                            }
                            id = nextId++;
                            parts[0] = id.ToString();
                            lines[i] = string.Join("|", parts);
                        }
                        else
                        {
                            existingIds.Add(id);
                        }
                        string updatedLine = string.Join("|", parts);
                        updatedLines.Add(updatedLine);

                        string text = parts[1];
                        string type = parts[2];
                        string author = parts[3];
                        bool isFavorite = bool.Parse(parts[4]);
                        curiosities.Add(new Curiosity(id, text, type, author, isFavorite));
                    }
                }
            }

            File.WriteAllLines(filepath, lines);
        }
    }
    public Curiosity GetCuriosityById(int id)
    {
        return curiosities.FirstOrDefault(c => c.Id == id);
    }
    public Curiosity GetRandom() 
	{
        if (curiosities.Count == 0) 
		{
			return null;
		}
		Random random = new Random();
		int randomIndex = random.Next(0, curiosities.Count);
		return curiosities[randomIndex];
	}
    public void SetFavorite(int id, bool isFavorite)
    {
        var curiosity = GetCuriosityById(id);
        if (curiosity != null)
        {
            curiosity.IsFavorite = !isFavorite;
            hasChanges = true;
        }
    }
    public void SaveAll()
    {
        List<string> lines = curiosities.Select(c => $"{c.Id}|{c.Text}|{c.Type}|{c.Author}|{c.IsFavorite}").ToList();
        hasChanges = false;
        File.WriteAllLines(filepath, lines);
    }
    
    public List<Curiosity> FilterCuriosities(string searchText, string searchCriteria, bool filterByFavorites = false)
    {
        IEnumerable<Curiosity> filteredCuriosities = curiosities;

        if (filterByFavorites)
        {
            filteredCuriosities = filteredCuriosities.Where(c => c.IsFavorite);
        }

        switch (searchCriteria)
        {
            case "Текст":
                filteredCuriosities = filteredCuriosities.Where(c => c.Text.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0);
                break;
            case "Тип":
                filteredCuriosities = filteredCuriosities.Where(c => c.Type.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0);
                break;
            case "Автор":
                filteredCuriosities = filteredCuriosities.Where(c => c.Author.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0);
                break;
            case "ID":
                if (int.TryParse(searchText, out int id))
                {
                    filteredCuriosities = filteredCuriosities.Where(c => c.Id == id);
                }
                break;
            default:
                break;
        }

        return filteredCuriosities.ToList();
    }

    public bool HasChanges()
    {
        return hasChanges;
    }
    public List<string> GetActionHistory()
    {
        return actionHistory.GetHistory();
    }
}

public class ActionHistory
{
    private const int MaxHistorySize = 100;
    private List<string> history = new List<string>();
    private string filePath;
    public ActionHistory(string filePath)
    {
        this.filePath = filePath;
        history = new List<string>();
        LoadHistory();
    }
    public void AddAction(string action)
    {
        history.Add($"{DateTime.Now}: {action}");
        if (history.Count > MaxHistorySize)
        {
            history.RemoveAt(0);
        }
        SaveHistory();
    }

    public List<string> GetHistory()
    {
        return history;
    }

    private void LoadHistory()
    {
        if (File.Exists(filePath))
        {
            history = File.ReadAllLines(filePath).ToList();
        }
    }

    private void SaveHistory()
    {
        File.WriteAllLines(filePath, history);
    }
}

