using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


public class Product2
{

    public string id;
    public string name;

    public Product2(string id, string name)
    {
        this.id = id;
        this.name = name;
    }
}

public class ProductsImpl
{
    List<Product2> ProductsList = new List<Product2>();

    int index = 0;
    /*  public Product2 pr3 = new Product2("asdsad22", "asdsadsa22");
      */
    //добавляет новый продукт
    // возвращает true - если продукта с таким id еще не было
    // возвращает false - если был такой id, вставка отменяется
    //bool
    public bool addProduct(Product2 product)
    {
        //Тестовые данные
        Product2 pr1 = new Product2("121", "123");
        Product2 pr2 = new Product2("12", "123");
        ProductsList.Add(pr1);
        ProductsList.Add(pr2);

        //Реализация
        bool Prod = false;
        bool resultAdd = false;
        //Проверяем есть ли такой элемент в спсике
        for (int i = 0; i < ProductsList.Count; i++)
        {
            if (ProductsList[i].id == product.id)
            {
                Prod = true;
            }
        }
        if(Prod != true)
        {
            ProductsList.Add(product);
            resultAdd = true;
        }


        return resultAdd;


    }

    //Удаляет продукт
    // возвращает true - если продукт с таким id был
    // возвроащает false - если id не было, (удаления не происходит)
    //bool
    public bool deleteProduct(Product2 product)
    {
        //Тестовые данные
        Product2 pr1 = new Product2("12", "123");
        Product2 pr2 = new Product2("122", "123");
        ProductsList.Add(pr1);
        ProductsList.Add(pr2);
        
        //Реализация
        bool Prod = false;
        int ProdItemDelte = 0;
        bool resultDelete = false;

        //Проверяем есть ли такой элемент в спсике
        for (int i = 0; i < ProductsList.Count; i++)
        {
            if (ProductsList[i].id == product.id)
            {
                Prod = true;
                ProdItemDelte = i;
            }
        }
        if (Prod == true)
        {
            //Console.WriteLine(true);
            ProductsList.RemoveAt(ProdItemDelte);
            resultDelete = true;
        }


        return resultDelete;
    }


    //Получает имя (name) продукта
    // возращает name продукта у которого идентификатор равен (=) id
    // если продукта нет, вернуть пустую строку ""
    //String
    public String getName(String id)
    {
        //Тестовые данные
        Product2 pr1 = new Product2("121", "Привет");
        Product2 pr2 = new Product2("12", "Пока");
        ProductsList.Add(pr1);
        ProductsList.Add(pr2);

        //Реализация
        bool Prod = false;
        int ProdItemName = 0;
        String resultName = "";
        //Проверяем есть ли такой элемент в спсике
        for (int i = 0; i < ProductsList.Count; i++)
        {
            if (ProductsList[i].id == id)
            {
                Prod = true;
                ProdItemName = i;
            }
        }
        if (Prod == true)
        {
            //Console.WriteLine(ProductsList[ProdItemName].name);
            resultName = ProductsList[ProdItemName].name;
        }


        return resultName;

    }


    //возвращает массив (список) идентификаторов (id)
    // У котрых наименование равно (=) name
    // Если таких нет, возвращается пустой массив (список)
    //List
    public List<String> findByName(String name)
    {

        //Тестовые данные
        Product2 pr1 = new Product2("121", "Привет");
        Product2 pr2 = new Product2("12", "Пока");
        Product2 pr3 = new Product2("123", "Привет");
        Product2 pr4 = new Product2("1234", "Привет");

        ProductsList.Add(pr1);
        ProductsList.Add(pr2);
        ProductsList.Add(pr3);
        ProductsList.Add(pr4);

        //Реализация
        List<String> resultList = new List<String>();

        for (int i = 0; i < ProductsList.Count; i++)
        {
            if (ProductsList[i].name == name)
            {
                    resultList.Add(ProductsList[i].id);
            }
        }

        return resultList;
    }

}


