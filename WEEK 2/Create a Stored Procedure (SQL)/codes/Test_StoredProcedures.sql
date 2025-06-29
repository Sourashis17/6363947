-- Test fetching employees from IT department (DepartmentID = 3)
EXEC sp_GetEmployeesByDepartment @DepartmentID = 3;

-- Test inserting a new employee
EXEC sp_InsertEmployee 
    @FirstName = 'Sourashis', 
    @LastName = 'Bhaumik', 
    @DepartmentID = 2, 
    @Salary = 8000.00, 
    @JoinDate = '2024-12-01';

-- Verify insertion
SELECT * FROM Employees;
