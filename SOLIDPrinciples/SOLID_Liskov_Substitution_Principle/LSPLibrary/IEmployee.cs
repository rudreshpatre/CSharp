namespace LSPLibrary
{
    public interface IEmployee
    {
        string FirstName { get; set; }
        string Lastname { get; set; }       
        decimal Salary { get; set; }        
        void CalculatePerHourRate(int rank);
    }
}