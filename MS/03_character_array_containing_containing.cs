var array = new char[] {  };
var start = 0;
var len = 1;

var arrayLen = array.Length;
var result = new char[len];

if(start+len > arrayLen || start < 0 || len < 0)
{
    Console.WriteLine("null");
}
else
{
    var j = 0;
    for (var i = start; i < start+len; i++)
    {
        result[j] = array[i];
        j++;
    }

    foreach (var k in result)
        Console.WriteLine(k);
}
