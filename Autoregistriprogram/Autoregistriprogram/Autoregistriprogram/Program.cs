
using System.Numerics;

#include <iostream>
#include <vector>
#include <string>

using namespace std;

class Car
{
    public:
    string brand;
    string model;
    string plate;
    bool scrapped;

    Car(string b, string m, string p)
    {
        brand = b;
        model = m;
        plate = p;
        scrapped = false;
    }

    void showCar()
    {
        cout << brand << " " << model << " | " << plate;
        if (scrapped)
            cout << " | MAHA KANTUD";
        cout << endl;
    }
};

class User
{
    public:
    string email;
    string username;
    string password;
    vector<Car> cars;

    User(string e, string u, string p)
    {
        email = e;
        username = u;
        password = p;
    }

    void addCar()
    {
        string brand, model, plate;
        cout << "Sisesta mark: ";
        cin >> brand;
        cout << "Sisesta mudel: ";
        cin >> model;
        cout << "Sisesta number: ";
        cin >> plate;

        cars.push_back(Car(brand, model, plate));
        cout << "Auto lisatud!\n";
    }

    void showCars()
    {
        if (cars.empty())
        {
            cout << "Autosid ei ole.\n";
            return;
        }

        for (int i = 0; i < cars.size(); i++)
        {
            cout << i + 1 << ". ";
            cars[i].showCar();
        }
    }

    void scrapCar()
    {
        showCars();
        int choice;
        cout << "Milline auto maha kanda? ";
        cin >> choice;

        if (choice > 0 && choice <= cars.size())
        {
            cars[choice - 1].scrapped = true;
            cout << "Auto märgiti mahakantuks.\n";
        }
        else
        {
            cout << "Vale valik.\n";
        }
    }
};

vector<User> users;

bool validEmail(string email)
{
    return email.find('@') != string::npos;
}

void registerUser()
{
    string email, username, password;

    cout << "Sisesta email: ";
    cin >> email;

    if (!validEmail(email))
    {
        cout << "Email peab sisaldama @ märki!\n";
        return;
    }

    cout << "Sisesta username: ";
    cin >> username;

    cout << "Sisesta parool: ";
    cin >> password;

    users.push_back(User(email, username, password));
    cout << "Registreerimine õnnestus!\n";
}

int login()
{
    string username, password;

    cout << "Username: ";
    cin >> username;
    cout << "Password: ";
    cin >> password;

    for (int i = 0; i < users.size(); i++)
    {
        if (users[i].username == username && users[i].password == password)
        {
            return i;
        }
    }

    return -1;
}

void userMenu(int index)
{
    int choice;

    do
    {
        cout << "\n1. Vaata autosid\n";
        cout << "2. Lisa auto\n";
        cout << "3. Kanna auto maha\n";
        cout << "0. Logout\n";
        cout << "Valik: ";
        cin >> choice;

        switch (choice)
        {
            case 1:
                users[index].showCars();
                break;
            case 2:
                users[index].addCar();
                break;
            case 3:
                users[index].scrapCar();
                break;
        }
    } while (choice != 0);
}

int main()
{
    int choice;

    do
    {
        cout << "\n1. Registreeri\n";
        cout << "2. Logi sisse\n";
        cout << "0. Exit\n";
        cout << "Valik: ";
        cin >> choice;

        switch (choice)
        {
            case 1:
                registerUser();
                break;
            case 2:
                {
                    int index = login();
                    if (index != -1)
                    {
                        cout << "Sisselogimine õnnestus!\n";
                        userMenu(index);
                    }
                    else
                    {
                        cout << "Vale username või parool!\n";
                    }
                    break;
                }
        }

    } while (choice != 0);

    return 0;
}