// 1. Generic Swap Utility (Type-safe)
// Implement Swap<T> to swap two variables in a type-safe way (no boxing, no object).

// using System;                                   
// public class Program                               
// {
//     public static void Main()                      
//     {
//         int a = 10;                               
//         int b = 20;                                

//         Swap<int>(ref a, ref b);                   

//         Console.WriteLine($"a={a}, b={b}");        

//         string x = "Sukku";                          
//         string y = "Karthikkk";                        

//         Swap(ref x, ref y);                         
//         Console.WriteLine($"x={x}, y={y}");         
//     }
//     public static void Swap<T>(ref T left, ref T right)
//     {

//         T temp = left;   
//         left = right;    
//         right = temp;    
//     }
// }


// 2. Generic Repository Add & Get (In-Memory)
// Implement a generic repository that can store any type T. Students must implement only Add and GetAll.

// using System;
// public class Program
// {
//     public static void Main()
//     {
//         var intRepo = new SimpleRepo<int>();       
//         intRepo.Add(10);
//         intRepo.Add(20);

//         Console.WriteLine(string.Join(",", intRepo.GetAll())); 

//         var nameRepo = new SimpleRepo<string>(); 
//         nameRepo.Add("Sukku");
//         nameRepo.Add("Karthikkk");

//         Console.WriteLine(string.Join(",", nameRepo.GetAll())); 
//     }
// }
// public class SimpleRepo<T>
// {
//     private readonly List<T> _items = new();       
//     public void Add(T item)
//     {
//         _items.Add(item);
//     }
//     public IReadOnlyList<T> GetAll()
//     {
//         return _items;
//     }
// }


// 3. Generic Constraint: Accept Only Reference Types
// Implement a cache that stores a value and returns a safe fallback when the value is null. Cache should accept only reference types using constraint.

// using System;

// public class Program
// {
//     public static void Main()
//     {
//         var cache = new RefCache<string>();         
//         cache.Set(null);                           
//         Console.WriteLine(cache.GetOrDefault("NA")); 

//         cache.Set("Hello");
//         Console.WriteLine(cache.GetOrDefault("NA")); 

//     }
// }

// public class RefCache<T> where T : class           
// {
//     private T? _value;                             

//     public void Set(T? value)
//     {
//         _value = value;                             
//     }


//     public T GetOrDefault(T defaultValue)
// {
//     return _value ?? defaultValue;
// }
// }


// 4. Func<T> Delegate: Generic Calculator
// Implement Apply so it takes a function (Func<T,T,T>) and applies it on two values.

// using System;

// public class Program
// {
//     public static void Main()
//     {
//         Console.WriteLine(Apply(5, 3, (a, b) => a + b));    
//         Console.WriteLine(Apply(5, 3, (a, b) => a * b));    
//         Console.WriteLine(Apply("Hi", "Tech", (a, b) => a + " " + b)); 
//     }
//     public static T Apply<T>(T x, T y, Func<T, T, T> op)
// {
//     if (op == null)
//         throw new ArgumentNullException(nameof(op));

//     return op(x, y);
// }
// }


// 5. Predicate<T> Filter with Generic List
// Implement Filter using Predicate<T>. Return only items that match the condition.

// using System;

// public class Program
// {
//     public static void Main()
//     {
//         var nums = new List<int> { 2, 5, 8, 11, 14 };

//         var evens = Filter(nums, n => n % 2 == 0);
//         Console.WriteLine(string.Join(",", evens));         

//         var big = Filter(nums, n => n >= 10);
//         Console.WriteLine(string.Join(",", big));           
//     }

//     public static List<T> Filter<T>(List<T> items, Predicate<T> match)
// {
//     if (items == null)
//         throw new ArgumentNullException(nameof(items));

//     if (match == null)
//         throw new ArgumentNullException(nameof(match));

//     var result = new List<T>();

//     foreach (var item in items)
//     {
//         if (match(item))
//         {
//             result.Add(item);
//         }
//     }

//     return result;
// }
// }



// 6. Multicast Delegate: Notification Pipeline
// Implement BuildPipeline to combine multiple notification methods into a multicast delegate.

// using System;

// public class Program
// {
//     public delegate void Notifier(string message);

//     public static void Main()
//     {
//         Notifier pipeline = BuildPipeline();       
//         pipeline("Order Created");                  
//     }
//     public static Notifier BuildPipeline()
// {
//     Notifier pipeline = null!;

//     pipeline += SendEmail;
//     pipeline += SendSms;
//     pipeline += WriteLog;

//     return pipeline;
// }


//     private static void SendEmail(string message)
//     {
//         Console.WriteLine($"Email: {message}");
//     }

//     private static void SendSms(string message)
//     {
//         Console.WriteLine($"SMS: {message}");
//     }

//     private static void WriteLog(string message)
//     {
//         Console.WriteLine($"Log: {message}");
//     }
// }



// Generic Constraint: Numeric-like Aggregation (struct)
// Implement Sum for value types only. Use dynamic safely inside (common in interview tasks).

// using System;
// public class Program
// {
//     public static void Main()
//     {
//         Console.WriteLine(Sum(new List<int> { 1, 2, 3 }));      
//         Console.WriteLine(Sum(new List<double> { 1.5, 2.5 }));  

//     }
//     public static T Sum<T>(IEnumerable<T> items) where T : struct
// {
//     if (items == null)
//         throw new ArgumentNullException(nameof(items));

//     dynamic sum = default(T);

//     foreach (var item in items)
//     {
//         sum += (dynamic)item;
//     }

//     return (T)sum;
// }
// }


// 8. Generic Variance: Covariance & Contravariance (Interfaces)
// Complete missing variance keywords (out / in) and implement required function so the assignments compile.


// using System;

// public class Animal { public string Name = "Animal"; }
// public class Dog : Animal { public Dog() { Name = "Dog"; } }
// public interface IProducer<out T>
// {
//     T Produce();
// }

// public interface IConsumer<in T>
// {
//     void Consume(T item);
// }


// public class DogProducer : IProducer<Dog>
// {
//     public Dog Produce() => new Dog();
// }

// public class AnimalConsumer : IConsumer<Animal>
// {
//     public void Consume(Animal item)
//     {
//         Console.WriteLine($"Consumed: {item.Name}");
//     }
// }
// public class Program
// {
//     public static void Main()
//     {

//         IProducer<Animal> p = new DogProducer();      
//         IConsumer<Dog> c = new AnimalConsumer();      

//         Use(p, c);                                   
//     }
//     public static void Use(IProducer<Animal> producer, IConsumer<Dog> consumer)
// {
//     Animal animal = producer.Produce();

//     if (animal is Dog dog)
//     {
//         consumer.Consume(dog);
//     }
// }
// }



// 9. Generic Event with Delegate: Stock Alert
// Implement a generic publisher that raises an event when a value crosses a threshold. Students implement only Update.


// using System;

// public class ThresholdChangedEventArgs<T> : EventArgs
// {
//     public T OldValue { get; set; }                   
//     public T NewValue { get; set; }                   
//     public string Message { get; set; } = "";          
// }

// public class ThresholdMonitor<T> where T : IComparable<T>
// {
//     private readonly T _threshold;                    
//     private T _current;                               

//     public ThresholdMonitor(T threshold, T initial)
//     {
//         _threshold = threshold;                       
//         _current = initial;                          
//     }

//     public event EventHandler<ThresholdChangedEventArgs<T>>? ThresholdCrossed;
//     public void Update(T newValue)
// {
//     bool wasBelow = _current.CompareTo(_threshold) < 0;
//     bool isNowAboveOrEqual = newValue.CompareTo(_threshold) >= 0;

//     if (wasBelow && isNowAboveOrEqual)
//     {
//         ThresholdCrossed?.Invoke(this,
//             new ThresholdChangedEventArgs<T>
//             {
//                 OldValue = _current,
//                 NewValue = newValue,
//                 Message = $"Threshold crossed: {_threshold}"
//             });
//     }

//     _current = newValue;
// }
// }

// public class Program
// {
//     public static void Main()
//     {
//         var monitor = new ThresholdMonitor<int>(threshold: 100, initial: 90);

//         monitor.ThresholdCrossed += (sender, e) =>
//         {
//             Console.WriteLine(e.Message);
//             Console.WriteLine($"Old={e.OldValue}, New={e.NewValue}");
//         };

//         monitor.Update(95);                           
//         monitor.Update(101);                          
//     }
// }



// 10. Delegate-based Retry Utility (Generic + Exception Filter)
// Implement ExecuteWithRetry that retries a function for a limited number of attempts. Students fill only the function. This tests delegates, generics, and clean error handling.


using System;

public class Program
{
    private static int _tries = 0;                    

    public static void Main()
    {
        int result = ExecuteWithRetry(() =>
        {
            _tries++;
            if (_tries <= 2) throw new InvalidOperationException("Temporary failure");
            return 999;
        }, maxAttempts: 3);

        Console.WriteLine(result);                    
    }
    public static T ExecuteWithRetry<T>(Func<T> work, int maxAttempts)
{
    if (work == null)
        throw new ArgumentNullException(nameof(work));

    if (maxAttempts <= 0)
        throw new ArgumentOutOfRangeException(nameof(maxAttempts), 
            "maxAttempts must be greater than 0.");

    Exception? lastException = null;

    for (int attempt = 1; attempt <= maxAttempts; attempt++)
    {
        try
        {
            return work(); 
        }
        catch (Exception ex)
        {
            lastException = ex;

            if (attempt == maxAttempts)
                throw;
        }
    }
    throw lastException!;
}

}