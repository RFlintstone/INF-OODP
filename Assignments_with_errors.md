**Assignments which couldn't be completed due to breaking errors**

> Note: This list does not include the assingments which generated errors after I finished them. (From what I heard there is a minimum of 4-5 of those)  

- W01.2.H07 Times Table Trouble - 2024-02-07
  - Codegrade doesn't find the nested for loop I defined
- W02.1.H01 Leap year - 2024-02-09
  - Codegrade doesn't find the nessesary methods which I did define
- W02.2.H02 TODO List - 2024-02-11
    - ```
      CSC : error CS5001: Program does not contain a static 'Main' method suitable for an entry point [/home/codegrade/student/TestTodo/TestTodo.csproj]
      ```
- W03.2.H01 Day of the week - 2024-02-19
  - Codegrade check marks all unit tests but somehow I still get 2/3 rubric points
- W03.2.H02 Castle Battle - 2024-02-19
  - Print lines seems to be impossible to get right (Expected: ``EXP: 170¶HP: 24/90¶Strength: 38``, actual: ``DEAD``)
- W04.1.C08 finally block - 2024-02-20
  - Codegrade doesn't find the nessesary Close() method which I did call
- W04.2.H01 Grocery List with overloads - 2024-02-25
  - ```
    /home/codegrade/student/Files/Program.cs(62,55): error CS0029: Cannot implicitly convert type 'bool' to 'GroupedShopItem' [/home/codegrade/student/Files/Files.csproj]
    /home/codegrade/student/Files/Program.cs(62,63): error CS0029: Cannot implicitly convert type 'bool' to 'GroupedShopItem' [/home/codegrade/student/Files/Files.csproj]
    /home/codegrade/student/Files/Program.cs(62,71): error CS0029: Cannot implicitly convert type 'bool' to 'GroupedShopItem' [/home/codegrade/student/Files/Files.csproj]
    ```
- W05.2.C03 Properties - read/write, property set validation - 2024-03-04
  - Print lines seems to be impossible to get right 
    ```
    **Expected:** 
    temperature in celsius: -173
    temperature in kelvin: 100
    
    **Actual:**
    Temperature in Celsius: -274
    Temperature in Kelvin: 0
    ```
- W05.2.H01 Accessible literature - 2024-03-04
  - ``IO Test - Full`` impossible to get right, at least if you follow the instructions correctly. (Access modifier for the class should be public, but then the test fail because the test doesn't like public)
  - If you use the UML Diagram as a guide, you can't seem to get the right code. 
  - UML Diagram != Codegrade Assignment != Codegrade Unit Test