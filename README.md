# __Home Work 28/03/23__
# :man_technologist:  Develop a Store application that generates a list of certain devices, for example, such as Mobile Phone, Laptop, Tablet. All three classes are derived from the abstract class "Device". Work with objects of the corresponding classes is performed through references to the base class, which are stored in a list. The application must provide the following features:
* ## Adding a device to the list 
* ## Removing a device from the list by a specified criterion 
* ## Printing a list 
* ## Searching for a device by a specified criterion
# __Diagram Store Project__ :point_down:
[![Diagram.jpg](https://i.postimg.cc/bwXMBDDZ/Diagram.jpg)](https://postimg.cc/qzLjt7Gr)
# __Project Map__ :world_map:
> ## [<span style="color:red;">Store.cs</span>](https://github.com/mykha8lad/store/blob/main/Store.cs) :convenience_store:
>> ## Devices :file_folder: 
>>> ## [<span style="color:red;">Device.cs</span> <span style="color:White;">- Abstract</span>](https://github.com/mykha8lad/store/blob/main/Devices/Device.cs) :shopping_cart::recycle:
>>> ## [<span style="color:red;">Laptop.cs</span>](https://github.com/mykha8lad/store/blob/main/Devices/Laptop.cs) :computer:
>>> ## [<span style="color:red;">MobilePhone.cs</span>](https://github.com/mykha8lad/store/blob/main/Devices/MobilePhone.cs) :calling:
>>> ## [<span style="color:red;">Tablet.cs</span>](https://github.com/mykha8lad/store/blob/main/Devices/Tablet.cs) :iphone:
>> ## StrategyPattern :file_folder:
>>> ## FindDevice :file_folder:
>>>> ## [<span style="color:red;">IFindStrategy.cs</span> <span style="color:White;">- Interface</span>](https://github.com/mykha8lad/store/blob/main/StrategyPattern/FindDevice/IFindStrategy.cs) :mag:
>>>> ## [<span style="color:red;">FindManufacturer.cs</span>](https://github.com/mykha8lad/store/blob/main/StrategyPattern/FindDevice/FindManufacturer.cs) :mag:
>>>> ## [<span style="color:red;">FindModel.cs</span>](https://github.com/mykha8lad/store/blob/main/StrategyPattern/FindDevice/FindModel.cs) :mag:
>>>> ## [<span style="color:red;">FindSeries.cs</span>](https://github.com/mykha8lad/store/blob/main/StrategyPattern/FindDevice/FindSeries.cs) :mag:
>>> ## RemoveDevice :file_folder:
>>>> ## [<span style="color:red;">IRemoveStrategy.cs</span> <span style="color:White;">- Interface</span>](https://github.com/mykha8lad/store/blob/main/StrategyPattern/RemoveDevice/IRemoveStrategy.cs) :wastebasket:
>>>> ## [<span style="color:red;">RemoveManufacturer.cs</span>](https://github.com/mykha8lad/store/blob/main/StrategyPattern/RemoveDevice/RemoveManufacturer.cs) :wastebasket:
>>>> ## [<span style="color:red;">RemoveModel.cs</span>](https://github.com/mykha8lad/store/blob/main/StrategyPattern/RemoveDevice/RemoveModel.cs) :wastebasket:
>>>> ## [<span style="color:red;">RemoveSeries.cs</span>](https://github.com/mykha8lad/store/blob/main/StrategyPattern/RemoveDevice/RemoveSeries.cs) :wastebasket:
> ## [<span style="color:red;">Program.cs</span>](https://github.com/mykha8lad/store/blob/main/Program.cs) :hammer_and_wrench:
## To implement the search and retrieval of an element (in our case, a device), the "Strategy" behavioral design pattern was used to encapsulate the implementation of methods, as well as to dynamically bind to a particular method, depending on the __criterion__ provided by the user.
[![photo-2023-04-07-14-56-30.jpg](https://i.postimg.cc/R0mbRk3y/photo-2023-04-07-14-56-30.jpg)](https://postimg.cc/tsr5RmNN)
```cs
private IRemoveStrategy? _removeStrategy;
private IFindStrategy? _findStrategy;

public IRemoveStrategy RemoveStrategy
{
get => _removeStrategy;
set => _removeStrategy = value;
}
public IFindStrategy FindStrategy
{
get => _findStrategy;
set => _findStrategy = value;
}

void SetStrategy(IRemoveStrategy removeStrategy) => RemoveStrategy = removeStrategy;
void SetStrategy(IFindStrategy findStrategy) => FindStrategy = findStrategy;
```
## __Usage example in Main()__
```cs
Tablet tablet = new("Apple", "iPad 2021", 13, 16.999, "Space Gray", "Apple iPad 10.2 2021 Space Gray", "iPadOS", 10.2);
Laptop laptop = new("Xiaomi", "Pro 14", 30, 29.999, "Silver", "Xiaomi Laptop Pro 14 Silver", "Intel Core i5-11320H", 16);
MobilePhone mobilePhone = new("Samsung", "Galaxy M33", 19, 8.499, "Green", "Samsung Galaxy M33 5G 6/128GB Green", "TFT", 128);

Store store = new();
```
## __Adding Devices to the Availability Feed__
```cs
store.AddDeviceInStore(tablet);
store.AddDeviceInStore(laptop);
store.AddDeviceInStore(mobilePhone);

store.DisplayStore();
```
[![69.png](https://i.postimg.cc/52MFznY7/69.png)](https://postimg.cc/qzjRVcGy)
___
## __Removing devices according to a user-specified criterion (t he Strategy pattern is used here)__
```cs
Console.Write("Enter key for remove device from this store\n> ");
string? key = Console.ReadLine();
store.DeleteDevice(key);
```
[![73.png](https://i.postimg.cc/wjrbK1GK/73.png)](https://postimg.cc/hX90TtnM)
[![photo-2023-04-07-15-06-09.jpg](https://i.postimg.cc/qqg3dvFY/photo-2023-04-07-15-06-09.jpg)](https://postimg.cc/ZvtR844F)
___
## __Search for devices by a user-specified criterion (the Strategy pattern is also used here)__
```cs
Console.Write("Enter key for find device in this store\n> ");
key = Console.ReadLine();
store.FindDevice(key);      
```
[![75.png](https://i.postimg.cc/2S12xz80/75.png)](https://postimg.cc/4YT6fRcc)
[![photo-2023-04-07-15-09-10.jpg](https://i.postimg.cc/J4MhJnKW/photo-2023-04-07-15-09-10.jpg)](https://postimg.cc/c6kZGdVD)
