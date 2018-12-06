[Microsoft Validation Doc](https://docs.microsoft.com/en-us/aspnet/mvc/overview/older-versions/getting-started-with-aspnet-mvc3/cs/adding-validation-to-the-model
)

```c#
      [Display(Name = "Age")]
      [Range(20, 40, ErrorMessage = "Customer Age should be between 20 to 40.")]
      public int Age { get; set; }

      [Display(Name = "Date of Birth")]
      [DataType(DataType.Date)]
      [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}" , ApplyFormatInEditMode = true)]
      [ValidBirthDate(ErrorMessage = "Birth Date can not be greater than current date")]
      public DateTime BirthDate { get; set; } 

```

```c#
 [Range(0, Double.PositiveInfinity)]
[Range(0.0, Double.MaxValue)]

```
