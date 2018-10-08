# Welcome to HW3

The third assignment for this class was to use Visual Studio to translate from Java to C#. We will eventually be using both Visual Studio and C# to code our Web Application in MVC framework, so it'll be in my best interest to get familiar with both now. 

## Prepare

1. First thing in this assignment was to get Visual Studio and get familiar with it. Although I've played around with it during summer, I know it's a powerful tool so I guess I'll learn more about it as I go.
2. After the environment setup was complete, I decided to look at the Java code that we needed to translate. I compiled it and ran it a couple of times to understand what it's acutally doing.
3. As seen in the HW3 assignment page, Dr.Morse advised us to translate the classes in the order of Node/QueueInterface/QueueUnderflowException/LinkedQueue/Main, So I followed and translated it in that order. 
4. Open up Visual Studio -> C# Console App -> Start Translating!

## Libraries / Conversion

1. For this translation, it is important NOT TO COPY AND PASTE! but instead translate as you go. There are many similarities in C# and Java, but there are differences as well.
2. In Java the QueueUnderflowExcpetion Class was coded like this:

``` Java
public class QueueUnderflowException extends RuntimeException
{
  public QueueUnderflowException()
  {
    super();
  }

  public QueueUnderflowException(String message)
  {
    super(message);
  }
}
```

But in C# the same class with the same functionality ends up looking like this:

```C#
 class QueueUnderflowException : SystemException
    {
        public QueueUnderflowException() : base()
        {
            
        }

        public QueueUnderflowException(string msg) : base(msg)
        {

        }

    }


## XML Comments 

## ScreenShot of Working Application