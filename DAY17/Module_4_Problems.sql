/* 1.	List the customer number, the name, the phone number, and the city of customers */
SELECT custNumb, custName, custPhone, custCity
FROM Customers;

/* 2.	List the customer number, the name, the phone number,
 and the city of customers who reside in Colorado (State is CO). */
SELECT custNumb, custName, custPhone, custCity
FROM Customers
WHERE usState = 'CO';

/* 3.	List all columns of the EventRequest table for events costing more than $4000.
  Order the result by the event date (DateHeld). */
SELECT * 
FROM EventRequest
WHERE cost > 4000
ORDER BY dateHeld;


/* 4.	List the event number, the event date (DateHeld),
 and the estimated audience number with approved status 
 and audience greater than 9000 or with pending status and audience greater than 7000. */
 SELECT eventNum, dateHeld, estAudience, statusAud
 FROM EventRequest
 WHERE(statusAud = 'Approved' AND estAudience > 9000)
 OR(statusAud = 'Pending' AND estAudience > 7000);


/* 5.	List the event number, event date (DateHeld), customer number 
and customer name of events placed in January 2018 by customers from Boulder. */
SELECT eventNum, dateHeld, custNumb, custName
FROM EventRequest
WHERE dateHeld BETWEEN '2018-01-01' AND '2018-01-31'
AND city = 'Boulder';

/* 6.	List the average number of resources used (NumberFld) by plan number.
 Include only location number L100. */
 SELECT AVG(NumberFld)
 FROM ResourcesDB
 WHERE locationFld = 'L100';

/* 7.	List the average number of resources used (NumberFld) by plan number.
 Only include location number L100. Eliminate plans with less than two event lines
  containing location number L100. */

