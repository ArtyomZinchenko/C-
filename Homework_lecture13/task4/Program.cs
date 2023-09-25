// Разработать приложение «Резервная копия» Цель: произвести расчет необходимого количества внешних носителей информации заданного типа при
//  переносе за один раз важной информации (565 Гб, файлы по 780 Мб) с рабочего компьютера на домашний компьютер и затрачиваемое на данный 
//  процесс время. 
// Вы имеете в распоряжении следующие типы носителей информации: 
// ■ Flash-память, 
// ■ DVD-диск, 
// ■ съемный HDD. 
// Каждый носитель информации является объектом соответствующего класса: 
// ■ Flash-память — класс «Flash»;
// ■ класс DVD-диск — класс «DVD»; 
// ■ класс съемный HDD — класс «HDD». 

// Все три класса являются производными от абстрактного класса «Носитель информации» — класс «Storage». Базовый класс («Storage») содержит следующие 
// закрытые поля: 
// ■ наименование носителя; 
// ■ модель. 
// Класс обладает всеми необходимыми свойствами для доступа к полям, а также абстрактными методами: 
// ■ получение объема памяти; 
// ■ копирование данных (файлов/папок) на устройство, 
// ■ получение информации о свободном объеме памяти на устройстве; 
// ■ получение общей/полной информации об устройстве. 

// Кроме того, каждый из производных классов дополняется следующими полями: 
// ■ класс Flash-память: скорость USB 3.0, объем памяти; 
// ■ класс DVD-диск: скорость чтения / записи, тип (односторонний (4.7 Гб) Домашнее задание № 10-11 /двусторонний (9 Гб)); 
// ■ класс съемный HDD: скорость USB 2.0, количество разделов, объем разделов. 

// Работа с объектами соответствующих классов производится через ссылки
//  на базовый класс («Storage»), которые хранятся в массиве. Приложение должно продемонстрировать основные возможности разработанных классов."

using System;

class Program
{
    static void Main()
    {
        Storage[] devices = new Storage[]
        {
            new Flash("Flash Drive 1", "Toshiba123", 64,  3.0, 12.76),
            new DVD("DVD Drive 1", "DVD456", 4.7, 16, 16, false, 1.32),
            new HDD("External HDD 1", "Samsung321", 1000, 2.0, 3, 64.87, new double[] { 300, 300, 400 })
        };

        double totalDataSize = 565; // in GB
        double totalDataSizeInGigabits = totalDataSize * 8; // Convert total data size to Gbps
        // double dataSizePerFile = 0.78; // in GB; But not really necessary?

        foreach (var device in devices)
        {
            double requiredDevices = Math.Ceiling(totalDataSize / device.GetAvailableStorage());
            double totalTimeInSeconds = 0; 

            if (device is DVD dvdDevice)
            {
                totalTimeInSeconds = totalDataSizeInGigabits / ((dvdDevice.writeSpeed * 150)/1000); // Use writeSpeed 16 * 150 Mbps = 2400 Mbps = 2.4 Gbps
            }
            else if (device is HDD)
            {
                totalTimeInSeconds = totalDataSizeInGigabits / 4.8; // Use usbSpeed
            }
            else if (device is Flash)
            {
                totalTimeInSeconds = totalDataSizeInGigabits / 5; // Use usbSpeed
            }

            Console.WriteLine($"Device Info: {device.GetDeviceInfo()}");
            Console.WriteLine($"Required Devices: {requiredDevices}");
            Console.WriteLine($"Estimated Time: {totalTimeInSeconds} seconds");
            Console.WriteLine();
        }
    }
}

