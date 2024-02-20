#region Practice

//string data = Console.ReadLine();
//int result=int.Parse(data);
//Console.WriteLine(result);

//Data:  string data = Console.ReadLine();
//int response;

//bool isConvert = int.TryParse(data,out response);

//if (isConvert)
//{
//    Console.WriteLine("Response is ----" + response);
//}
//else
//{
//    Console.WriteLine("Format is wrong, please add input again ");
//    goto Data;
//}

//string[] names = { "Fatima", "Faxriyya", "Ilqar", "Afida", "Rashad", "Kamran" };

//string[] arr1 = new string[8];

//string[] arr2 = new string[3] { "Fatima", "Sadigkhan", "Faxriyya" };

//Console.WriteLine(names[names.Length-1]);


//int[,] nums = { { 1, 2, 3 }, { 5, 6, 8 }, { 11, 22, 55 } };
//Console.WriteLine(nums.Rank);
//Console.WriteLine(nums[1,2]);

//string[] names = { "Fatima", "Faxriyya", "Ilqar", "Afida", "Rashad", "Kamran" };
//Console.WriteLine(names.Contains("Faxriyya"));

//var datas = names.Reverse().ToArray();
//Console.WriteLine(datas[datas.Length-1]);
//Array.Sort(names);
//foreach (var item in names)
//{
//    Console.WriteLine(item);
//}

//int[] nums = { 13, 5, 17, 8 };

//Array.Sort(nums);
//foreach (var item in nums)
//{
//    Console.WriteLine(item);
//}

//int[] nums = { 13, 5, 17, 8 };
//Array.Sort(nums);
//var datas = nums.Reverse().ToArray();
//foreach (var item in datas)
//{
//    Console.WriteLine(item);
//}

//int[] arr1 = {1,2,3};
//int[] arr2 = {4,5};

//arr1.CopyTo(arr2, 2);

//int[] arr = {1,2,3 };

//Array.Resize(ref arr, 5);
//arr[3] = 200;
//Console.WriteLine(arr[3]);

//int[] arr1 = { 1, 2, 3 };
//int[] arr2 = { 4, 5 };

//Array.Resize(ref arr2, 5);
////Console.WriteLine(arr2[3]);
//arr1.CopyTo(arr2, 2);

//foreach (var item in arr2)
//{
//    Console.WriteLine(item);
//}

//string[] names = { "Fatima", "Fatima", "Faxriyya", "Ilqar", "Afida", "Rashad", "Kamran" };
//var datas = Array.FindAll(names, m => m == "Fatima");
//Console.WriteLine(data);
//foreach (var item in datas)
//{
//    Console.WriteLine(item);
//}
//var data = Array.FindIndex(names, m => m == "Fatima");
//Console.WriteLine(data);

//var data = Array.FindLastIndex(names, m => m == "Fatima");
//Console.WriteLine(data);

//var data = names.FirstOrDefault();
//var data = names.LastOrDefault();
//var data = names.FirstOrDefault(m=>m=="Faxriyya");
//Console.WriteLine(data);

//var data = names.All(m=>m=="Fatima");
//var data = names.Any(m => m == "Fatima");

//var data = Array.Exists(names,m => m == "Fatima");

//var datas = names.Where(m => m == "Fatima").ToArray();
//var datas = names.OrderBy(m => m);
//var datas = names.OrderByDescending(m => m);
//foreach (var item in datas)
//{
//    Console.WriteLine(item);
//}

//var data = names.Any(m => m == "Fatima");

//foreach (var item in names)
//{
//    if (item=="Fatima")
//    {
//        Console.WriteLine(true);
//        break;
//    }
//}

//string[] names = { "Fatima", "Fatima", "Faxriyya", "Ilqar", "Afida", "Rashad", "Kamran" };

//bool CheckAllData(string[] arr,string searchtext)
//{
//    int count = 0;

//    foreach (var item in names)
//    {
//        if (item == searchtext)
//        {
//            count++;
//        }
//    }
//    if (count == names.Length)
//    {
//        return true;
//    }
//    else
//    {
//        return false;
//    }
//}
//Console.WriteLine(CheckAllData(names,"Fatima"));

//DateTime date = DateTime.Now;

//DateTime dateday= DateTime.Now.AddYears(10);
//Console.WriteLine(dateday);

//DateTime birthday = new DateTime(2002,05,25);
//DateOnly birthday = new DateOnly(2002,05,25);
//Console.WriteLine(birthday);
//var date = DateTime.Now;
//Console.WriteLine(date.ToString("dddd,dd MMMM yyyy"));

//Console.WriteLine(date.ToString("MM/dd/yyyy HH:mm"));


#endregion
#region HomeWork
int GetCountOfChar(string[] arr,char n)
{
    int count = 0;
    string newStr = string.Empty;

    foreach (var item in arr)
    {
        newStr += item;
    }
    char [] newStrArray=newStr.ToLower().ToCharArray();
    foreach (var item in newStrArray)
    {
        if (item == n)
        {
            count++;
        }
    }
    return count;
}
string[] arr = {"H.el.lo","Nece.sen" };
int result= GetCountOfChar(arr,'.');
Console.WriteLine(result);
#endregion
