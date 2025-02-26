using System;

class TaskItem{
    private string desscription;
    private bool is_completed;

    public TaskItem(string desscription){
        this.desscription = desscription; 
        this.is_completed = false;
    }

    public string Desscription{
        get{
            return this.desscription;
        }
        set{
            this.desscription = value;
        }
    }

    public void MarkComplete(){
        if (this.is_completed){
            Console.WriteLine("You have already marked this as completed");
        }
        this.is_completed = true;
    }

    public void MarkinComplete(){
        if(this.is_completed){
            Console.WriteLine("Success");
            this.is_completed = false;
        }
    }
    public void ShowInfo(){
        Console.WriteLine("Task description: \n");

        Console.WriteLine($"{this.desscription}");

        if(this.is_completed){
            Console.WriteLine("Task status: Is completed");
        }
        else {
            Console.WriteLine("Task status: Is incompleted");
        }
        Console.WriteLine();
    }
}

    class Manager{
        List <TaskItem> items;
        int itemsCount;

        public Manager(){
            items = new List <TaskItem> ();
            itemsCount = 0;
        }

        public void AddTask(){
            Console.WriteLine("Enter a description: ");
            string? desc = Console.ReadLine ();
            items.Add(new TaskItem(desc));
            ++itemsCount;
        }
        public void RemoveTask(){
            Console.WriteLine("Enter task's description to delete: ");
            string? desc = Console.ReadLine();

            for(int i = 0; i < itemsCount; ++i){
                if(items[i].Desscription == desc){
                    items.Remove(items[i]);
                    --itemsCount;
                    break;
                }
                if(i == itemsCount - 1){
                    Console.WriteLine("There is no such task");
                    return;
                }

            }
        }
        public void MarkCompleteInList(){
            Console.WriteLine("Enter the description");
            string? description = Console.ReadLine ();
            for(int i = 0; i < itemsCount; ++i){
                if(items[i].Desscription == description){
                    items[i].MarkComplete();
                    break;
                }
                if(i == itemsCount - 1){
                    Console.WriteLine("There is no such task");
                }
            }
        }
        public void MarkInCompleteInList(){
            Console.WriteLine("ENter the description");
            string? desription = Console.ReadLine ();
            for(int i = 0; i < itemsCount; ++i){
                if(items[i].Desscription == desription){
                    items[i].MarkinComplete();
                    break;
                }
                if(i == itemsCount - 1){
                    Console.WriteLine("There is no such task");
                }
            }
        }

        public void ShowList(){
            for(int i = 0; i < itemsCount; ++i){
                items[i].ShowInfo();
            } 
        }

        public static void Run() {
        Manager manager = new Manager();
        string? answ;
        while (true) {
            Console.WriteLine();
            Console.WriteLine("Enter '+' to add a task");
            Console.WriteLine("Enter '-' to add a task");
            Console.WriteLine("Enter 'C' to mark a task as completed");
            Console.WriteLine("Enter 'I' to mark a task as incomleted");
            Console.WriteLine("Enter 'L' to show all Tasks");
            Console.WriteLine("Enter 'X' to exit");
            answ = Console.ReadLine();
            if (answ == "x" || answ == "X") {
                break;
            } else if (answ == "+") {
                manager.AddTask();
            } else if (answ == "-") {
                manager.RemoveTask();
            } else if (answ == "c" || answ == "C") {
                manager.MarkCompleteInList();
            } else if (answ == "i" || answ == "I") {
                manager.MarkInCompleteInList();
            } else if (answ == "l" || answ == "L") {
                manager.ShowList();
            } else {
                Console.WriteLine("invalid command, try again");
            }
        }
    }

    }
class Program{
    static void Main(string[] args){
        Manager.Run();
    }
    }
