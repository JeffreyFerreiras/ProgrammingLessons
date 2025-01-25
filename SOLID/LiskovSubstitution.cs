namespace SOLID
{
    //Liskov Substitution Principle 		- derived classes must be substitutable for their base class
    // A subclass should behave in such a way that it would not cause problems if used instead of a super class.
    // Jeff..Much like how your SpecLanguageExport does not break the entire export.

    // Arguments and return types can be changed. But only if the item passed into the parent type can be passed in
    // Think IEnumerable and passing it in instead of a list. 
    // Cannot introduce new exceptions. Becasue super classes may not be able to handle them.

    // Cannot create new behavior parent classes cannot handle, Such as making new properties and methods.
    // Cannot weaken the subclass with behavior the parent class can handle but child class cannot handle.

    // History Constraint - Cannot make a immutible property mutable. 

    class LiskovSubstitution
    {
    }
}
