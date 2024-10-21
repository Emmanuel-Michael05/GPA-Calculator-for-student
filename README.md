# GPA Calculator Console Application

## Description
This project is a console-based Grade Point Average (GPA) calculator that allows a user to input multiple courses with their respective details (course name, code, unit, and score). The program calculates the grade, grade unit, weight point, and displays the GPA based on the input values. It also prints the results in a tabular format.

## Features
- Allows users to input course details dynamically.
- Automatically calculates the grade, grade unit, and weight point based on the score.
- Displays the GPA calculation in a user-friendly table.
- Implements a grading system based on standard grading scales.

## Grading System
The GPA is calculated using the following grade scale:
| Score Range | Grade | Grade Unit | Remark        |
|-------------|-------|------------|---------------|
| 70 - 100    | A     | 5          | Excellent     |
| 60 - 69     | B     | 4          | Very Good     |
| 50 - 59     | C     | 3          | Good          |
| 45 - 49     | D     | 2          | Fair          |
| 40 - 44     | E     | 1          | Pass          |
| 0 - 39      | F     | 0          | Fail          |

## Formula for GPA Calculation
GPA is calculated using the following formula:
GPA = Total Weight Points / Total Course Units

markdown
Copy code

Where:
- **Weight Point** = (Course Unit) * (Grade Unit)
- **Grade Unit** is determined from the grading system mentioned above.

## How to Run
1. Clone or download this repository.
2. Open the project in Visual Studio Code or any C# IDE.
3. Run the application by pressing `F5` or using the terminal/console to execute:
   ```bash
   dotnet run
Follow the prompts to input course details.
Example Output
yaml
Copy code
Enter the number of courses: 3

Enter the name of course 1: Mathematics
Enter the code of course 1: MTH101
Enter the unit of course 1: 3
Enter the score for course 1: 85

Enter the name of course 2: Physics
Enter the code of course 2: PHY101
Enter the unit of course 2: 4
Enter the score for course 2: 78

Enter the name of course 3: Chemistry
Enter the code of course 3: CHM101
Enter the unit of course 3: 3
Enter the score for course 3: 66

-------------------------------------------------------------------
Course Code Course Name Score      Grade      Grade Unit Unit       Weight Pt
-------------------------------------------------------------------
MTH101      Mathematics 85         A          5          3          15
PHY101      Physics     78         A          5          4          20
CHM101      Chemistry   66         B          4          3          12
-------------------------------------------------------------------
Total Course Units Registered: 10
Total Course Units Passed: 10
Total Weight Points: 47
Your GPA is: 4.70
-------------------------------------------------------------------
Files
Program.cs: Contains the logic for taking input, processing GPA, and printing the result.
PrintTable.cs: Handles the printing of the GPA and course details in a tabular format.

Author
Emmanuel Michael Ikechukwu
