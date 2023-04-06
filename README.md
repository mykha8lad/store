# Дз от 28/03/23.
# Разработать приложение "Магазин" <br/> [Class Store](https://github.com/mykha8lad/HW-23-03-23-inheritance/blob/main/Group.cs)
```cs
Tablet tablet = new("Apple", "iPad 2021", 13, 16.999, "Space Gray", "Apple iPad 10.2 2021 Space Gray", "iPadOS", 10.2);
Laptop laptop = new("Xiaomi", "Pro 14", 30, 29.999, "Silver", "Xiaomi Laptop Pro 14 Silver", "Intel Core i5-11320H", 16);
MobilePhone mobilePhone = new("Samsung", "Galaxy M33", 19, 8.499, "Green", "Samsung Galaxy M33 5G 6/128GB Green", "TFT", 128);

Store store = new();

store.AddDeviceInStore(tablet);
store.AddDeviceInStore(laptop);
store.AddDeviceInStore(mobilePhone);

store.DisplayStore();
```
[![69.png](https://i.postimg.cc/52MFznY7/69.png)](https://postimg.cc/qzjRVcGy)
___
## Удаление по заданному критерию (серии продукта)
```cs
Console.WriteLine("Enter series key for remove device from this list");
string key = Console.ReadLine();
store.DeleteDevice(key);

store.DisplayStore();
```
[![70.png](https://i.postimg.cc/0NjDfZxp/70.png)](https://postimg.cc/NyhKG6KM)
___
## Поиск по заданному критерию (серии продукта)
```cs
Console.WriteLine("Enter series key for remove device from this list");
key = Console.ReadLine();
store.FindDevice(key);        
```
[![72.png](https://i.postimg.cc/G2JLswNz/72.png)](https://postimg.cc/njrb65nQ)
