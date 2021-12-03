using Assignment2.StateCommandMemento.Memento;

namespace Assignment2.StateCommandMemento.Command
{
    interface IData
    {
        string DataText { get; set; }

        DataMemento CreateMemento(DataManager dataManager);
        void SaveData(string dataText);
        void ResetAll();
    }
}