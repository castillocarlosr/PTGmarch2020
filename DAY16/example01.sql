/*Create table elsewhere.  Here is search  practice*/
SELECT * FROM Faculty;

SELECT * FROM Faculty
WHERE FacNo = '555-987-5555';

SELECT FacFirstName, FacLastName, FacSalary*1.1 AS IncreasedSaraly, FacHireDate
FROM Faculty
WHERE to_number(to_char(FacHireDate, 'YYYY')) > 2005;

-- Select rows from a Table or View 'TableOrViewName' in schema 'SchemaName'
SELECT OfferNo, Offering.COurseNo, OffDays, CrsUnits, OffLocation, OffTime
FROM Offering INNER JOIN Course
ON Offering.CourseNo = Course.CourseNo
INNER JOIN Faculty
ON Offering.FacNo = Faculty.FacNo
WHERE OffYear = 2016 AND OffTerm = 'FALL'
AND FacFirstName = 'Carlos'
AND FacLastName = 'Castillo';