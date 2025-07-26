/*
 * STACK vs HEAP MEMORY MANAGEMENT LESSON
 * =======================================
 * 
 * OVERVIEW:
 * This comprehensive lesson demonstrates the fundamental differences between stack and heap memory
 * allocation in .NET, covering string immutability, value types, reference types, boxing/unboxing,
 * and memory allocation patterns.
 * 
 * KEY LEARNING OBJECTIVES:
 * 1. Understand when data is stored on the stack vs heap
 * 2. Learn the performance implications of different memory allocation strategies
 * 3. Recognize when to use value types vs reference types
 * 4. Understand string immutability and its impact on performance
 * 5. Learn about boxing/unboxing overhead and how to avoid it
 * 
 * PRACTICAL APPLICATIONS:
 * - Performance optimization in high-throughput applications
 * - Memory-efficient data structure design
 * - Understanding garbage collection behavior
 * - Making informed architectural decisions
 * 
 * PREREQUISITES:
 * - Basic C# syntax and object-oriented programming concepts
 * - Understanding of classes vs structs
 * - Familiarity with method parameters and return values
 */

namespace StackAndHeap;

class Program
{
    // Value type struct (stored on stack)
    public struct Point
    {
        public int X;
        public int Y;

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public override string ToString() => $"({X}, {Y})";
    }

    // Reference type class (stored on heap)
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public override string ToString() => $"{Name}, Age: {Age}";
    }

    public static void Main(string[] args)
    {
        Console.WriteLine("=== STACK vs HEAP Demonstration ===\n");

        // 1. String Immutability Demo
        DemonstrateStringImmutability();

        // 2. Value Types (Stack) Demo
        DemonstrateValueTypes();

        // 3. Reference Types (Heap) Demo
        DemonstrateReferenceTypes();

        // 4. Boxing and Unboxing Demo
        DemonstrateBoxingUnboxing();

        // 5. Memory Allocation Demo
        DemonstrateMemoryAllocation();

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }

    /*
     * STRING IMMUTABILITY
     * ===================
     * WHAT: Strings in .NET are immutable - once created, they cannot be changed.
     * WHY: Thread safety, security, optimization (string interning), hash code consistency.
     * 
     * WHEN TO USE:
     * - Small number of string operations
     * - Need thread-safe string handling
     * - Working with string literals or constants
     * 
     * WHEN NOT TO USE:
     * - Extensive string concatenation (use StringBuilder instead)
     * - Performance-critical scenarios with many string operations
     * 
     * SHORTCOMINGS:
     * - Memory overhead: Each modification creates a new string object
     * - Performance impact: Garbage collection pressure from temporary strings
     * - Hidden allocations: String operations may create more objects than expected
     * 
     * ALTERNATIVES:
     * - StringBuilder for multiple concatenations
     * - Span<char> for performance-critical scenarios
     * - String.Create() for custom string building
     */
    private static void DemonstrateStringImmutability()
    {
        Console.WriteLine("1. STRING IMMUTABILITY:");
        Console.WriteLine("========================");

        string original = "Hello";
        string modified = original;

        Console.WriteLine($"Original: {original}");
        Console.WriteLine($"Modified: {modified}");

        // Attempt to change the string
        ChangeString(modified);

        Console.WriteLine($"After ChangeString() call:");
        Console.WriteLine($"Original: {original}");
        Console.WriteLine($"Modified: {modified}");
        Console.WriteLine("Strings are immutable - changes create new string objects!\n");
    }

    /*
     * VALUE TYPES (Stack)
     * ===================
     * WHAT: Value types store data directly in the memory location where the variable is declared.
     * WHY: Provides better performance for small data, automatic memory management, and copy semantics.
     * 
     * WHEN TO USE:
     * - Small, simple data structures (< 16 bytes recommended)
     * - Immutable data that doesn't need to be shared
     * - When you want copy semantics (independent copies)
     * - Performance-critical scenarios requiring cache locality
     * 
     * WHEN NOT TO USE:
     * - Large data structures (causes expensive copying)
     * - Need inheritance or polymorphism
     * - Need null references
     * - Data that should be shared across methods
     * 
     * IMPORTANT TO KNOW:
     * - Stack allocation is very fast (just moving a pointer)
     * - Automatic cleanup when leaving scope
     * - Limited stack space (~1MB typically)
     * - Stack overflow possible with deep recursion or large local data
     * - Structs should be immutable for best practices
     */
    private static void DemonstrateValueTypes()
    {
        Console.WriteLine("2. VALUE TYPES (Stack):");
        Console.WriteLine("=======================");

        // Primitive value types
        int num1 = 10;
        int num2 = num1; // Copy by value
        num2 = 20;

        Console.WriteLine($"num1: {num1}, num2: {num2}");
        Console.WriteLine("Changing num2 doesn't affect num1 (independent copies)\n");

        // Struct value types
        Point point1 = new Point(5, 10);
        Point point2 = point1; // Copy by value
        point2.X = 15;

        Console.WriteLine($"point1: {point1}, point2: {point2}");
        Console.WriteLine("Structs are value types - independent copies\n");
    }

    /*
     * REFERENCE TYPES (Heap)
     * =======================
     * WHAT: Classes are reference types stored on the heap with references on the stack.
     * WHY: Enables polymorphism, inheritance, and sharing of large objects efficiently.
     * 
     * WHEN TO USE:
     * - Need inheritance or polymorphism
     * - Large objects (> 16 bytes typically)
     * - Objects that need to be shared across methods
     * - Need null references
     * 
     * WHEN NOT TO USE:
     * - Small, simple data (use structs instead)
     * - Performance-critical scenarios with many small objects
     * - When you want copy semantics instead of reference semantics
     * 
     * IMPORTANT TO KNOW:
     * - Multiple variables can reference the same object
     * - Changes through one reference affect all references
     * - Garbage collection manages memory automatically
     * - Indirection overhead: stack -> heap lookup
     * - Can cause memory fragmentation over time
     */
    private static void DemonstrateReferenceTypes()
    {
        Console.WriteLine("3. REFERENCE TYPES (Heap):");
        Console.WriteLine("===========================");

        Person person1 = new Person("Alice", 25);
        Person person2 = person1; // Copy by reference

        Console.WriteLine($"Before change - person1: {person1}");
        Console.WriteLine($"Before change - person2: {person2}");

        person2.Name = "Bob";
        person2.Age = 30;

        Console.WriteLine($"After change - person1: {person1}");
        Console.WriteLine($"After change - person2: {person2}");
        Console.WriteLine("Reference types share the same object in memory!\n");
    }

    /*
     * BOXING AND UNBOXING
     * ====================
     * WHAT: Converting value types to reference types (boxing) and back (unboxing).
     * WHY: Enables value types to be treated as objects when needed for polymorphism.
     * 
     * WHEN TO USE:
     * - Need to store value types in object collections (pre-generics)
     * - Working with APIs that require object parameters
     * - Legacy code that uses object instead of generics
     * 
     * WHEN NOT TO USE:
     * - Performance-critical code (prefer generics)
     * - Modern code (use generic collections instead)
     * - When you can avoid it with proper design
     * 
     * PERFORMANCE IMPACT:
     * - Boxing: Heap allocation + copying value to heap
     * - Unboxing: Type checking + copying value back to stack
     * - Garbage collection pressure from boxed objects
     * - Can cause significant performance degradation in loops
     * 
     * ALTERNATIVES:
     * - Generic collections (List<T> instead of ArrayList)
     * - Generic methods and constraints
     * - Value tuples for multiple values
     */
    private static void DemonstrateBoxingUnboxing()
    {
        Console.WriteLine("4. BOXING and UNBOXING:");
        Console.WriteLine("========================");

        int valueType = 42;

        // Boxing: value type → reference type (stack → heap)
        object boxed = valueType;
        Console.WriteLine($"Boxing: int {valueType} → object {boxed}");

        // Unboxing: reference type → value type (heap → stack)
        int unboxed = (int)boxed;
        Console.WriteLine($"Unboxing: object {boxed} → int {unboxed}");
        Console.WriteLine("Boxing creates heap allocation for value types\n");
    }

    /*
     * MEMORY ALLOCATION COMPARISON
     * ============================
     * WHAT: Demonstrates the practical differences between stack and heap allocation.
     * WHY: Understanding memory allocation helps with performance optimization and design decisions.
     * 
     * STACK CHARACTERISTICS:
     * - Very fast allocation (just pointer increment)
     * - LIFO (Last In, First Out) structure
     * - Automatic cleanup when leaving scope
     * - Limited size (~1MB default on Windows)
     * - Cache-friendly (better locality)
     * - Thread-specific (each thread has its own stack)
     * 
     * HEAP CHARACTERISTICS:
     * - Slower allocation (finding free space)
     * - Flexible size, can grow as needed
     * - Garbage collected (automatic but with overhead)
     * - Shared across all threads
     * - Can fragment over time
     * - Reference indirection overhead
     * 
     * BEST PRACTICES:
     * - Prefer stack allocation for small, short-lived data
     * - Use heap for large objects or data that outlives the method
     * - Consider object pooling for frequently allocated objects
     * - Be aware of allocation patterns in hot code paths
     */
    private static void DemonstrateMemoryAllocation()
    {
        Console.WriteLine("5. MEMORY ALLOCATION:");
        Console.WriteLine("=====================");

        // Stack allocation (fast, automatic cleanup)
        int stackVar = 100;
        Point stackStruct = new Point(1, 2);

        // Heap allocation (slower, garbage collected)
        Person heapObject = new Person("Charlie", 35);
        int[] heapArray = new int[] { 1, 2, 3, 4, 5 };

        Console.WriteLine($"Stack variable: {stackVar}");
        Console.WriteLine($"Stack struct: {stackStruct}");
        Console.WriteLine($"Heap object: {heapObject}");
        Console.WriteLine($"Heap array: [{string.Join(", ", heapArray)}]");
        Console.WriteLine("Stack: Fast access, limited size, automatic cleanup");
        Console.WriteLine("Heap: Flexible size, garbage collected, slower access\n");
    }

    private static void ChangeString(string input)
    {
        input = "Changed!"; // Creates a new string object
        Console.WriteLine($"Inside ChangeString(): {input}");
    }
}
