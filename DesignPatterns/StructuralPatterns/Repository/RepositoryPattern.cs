namespace DesignPatterns.StructuralPatterns.Repository
{
    /* allows your applications to perform with CRUD-like operations.
     * A more technical definition could be that it provides an abstraction
     * of data so that your application can work with for doing things like
     * inserting, removing, updating and selecting items.
     * So here, you can see some methods with InsertStudent, GetStudentByID, GetStudents.
     * 
     * NOTE: this is what you did with your ServiceBureau class at BNYM.
     */

    class MainApp
    {
        void DoWork(DatabaseRepository repo)
        {

        }
    }

    class DatabaseRepository
    {
        IList<object> _pretendDBA;

        public void InsertStudent(object student)
        {
            _pretendDBA.Add(student);
        }
    }

    /*
     * A generic repository allows for code reuse of different db models.
     */
}
