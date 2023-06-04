


using System.Xml.Linq;

class Program
{
    static void Main()
    {
        ProductsImpl productsi = new ProductsImpl();

        Product2 pr2 = new Product2("12", "Здравствуйте");


        //Вызов функции добавление
        productsi.addProduct(pr2);
        //Console.WriteLine(productsi.addProduct(pr2));

        //Вызов функции удаления
        productsi.deleteProduct(pr2);
        //Console.WriteLine(productsi.deleteProduct(pr2));

        //Вызов функции вывода name, если совпал id 
        productsi.getName("124");
        //Console.WriteLine(productsi.getName("12"));


        //Вызов функции вывода списка id, если совпал name
        //productsi.findByName("Привет");
        List<String> resultList = new List<String>();
        resultList = productsi.findByName("Привет");
        /*for (int i = 0; i < resultList.Count; i++)
        {
            Console.WriteLine(resultList[i]);
        }*/

    }

}








