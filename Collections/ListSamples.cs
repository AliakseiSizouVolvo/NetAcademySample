namespace Collections;

public class ListSamples
{
    public List<int> listCollection = new List<int>();

    public void Sample()
    {
        //adding elements to list
        listCollection.Add(1);
        listCollection.AddRange(new []{1,2,3,34,5,6});
        //listCollection.Insert()

        //check is element in the list
        var isInList = listCollection.Contains(1);

        //remove all data
        listCollection.Clear();

        //create an array from list 
        int[] arr = new int[listCollection.Count];
        listCollection.CopyTo(arr);
        listCollection.CopyTo(0, arr, 2, 3);
        var arr2 = listCollection.ToArray();

        //listCollection.Where(el=>el > 5 && el < 17).ToArray();
        //search index
        int? index = listCollection.IndexOf(15);

        //remove
        listCollection.Remove(1);
        listCollection.RemoveAt(0);
        //listCollection.RemoveAll();

        //{1,2,3,4,5} -> {5,4,3,2,1}
        listCollection.Reverse();
        listCollection.Reverse(1, 3);

        //sort
        listCollection.Sort();

        //if you have sorted collection
        listCollection.BinarySearch(6);
    }   
}