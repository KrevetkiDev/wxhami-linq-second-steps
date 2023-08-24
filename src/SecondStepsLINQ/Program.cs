using System.ComponentModel.Design;

void TaskOne()
{
    List<int> listForSortt = new List<int>() { 1, 3, 5, 10 };
    List<int> sortedListt = new List<int>();

    var num = listForSortt.Where(number => number > 3);
    
    List<int> Sort(List<int> listForSort, List<int> sortedList)
    {
        listForSort = listForSortt;
        sortedList = sortedListt;
        foreach (var number in listForSort)
        {
            if (number > 3)
            {
                sortedList.Add(number);
            }
        }
        return sortedList;
    }
}

void TaskTwo()
{
    List<int> listForSort = new List<int>() { 1, 3, 5, 10 };

    var firtNumber = listForSort.FirstOrDefault(number => number == 4);

    int GetElement(List<int> list, int number)
    {
        foreach (var numb in list)
                {
                    if (numb == number)
                    {
                        return numb;
                    }
                }

        return default;
    }
}

void TaskThree()
{
    List<int> listForSort = new List<int>() { 1, 3, 5, 10 };

    var sortedList = listForSort.OrderBy(number => number);
    
     void Sort(List<int> list)
     {
        for (int i = 0; i < list.Count - 1; i++)
        {
            for (int j = i + 1; j < list.Count; j++)
            {
                if (list[i] > list[j])
                {
                    var num = list[i];
                    list[i] = list[j];
                    list[j] = num;
                }
            }
        }
    }
}

void TaskFour()
{
    List<int> listForSort = new List<int>() { 1, 3, 5, 10 };

    var sortedList = listForSort.Select(num => num.ToString());

    List<string> GetArrayString(List<int> numbers)
    {
        List<string> newNumbers = new List<string>();
        foreach (var num in numbers)
        {
           string newNum = num.ToString();
           newNumbers.Add(newNum);
        }

        return newNumbers;
    }
}