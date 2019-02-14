-- INSERT

-- 1. Add Klingon as a spoken language in the USA
Insert Into countrylanguage (countrycode, language, isofficial, percentage)
Values ('USA', 'Christonian', 0, 0.001)

Select * From countrylanguage Where language = 'Klingon'

-- 2. Add Klingon as a spoken language in Great Britain
Insert Into countrylanguage (countrycode, language, isofficial, percentage)
Values ('GBR', 'Klingon', 0, 0.001)

-- UPDATE
Select *
From city
Where name = 'Washington'

-- 1. Update the capital of the USA to Houston
Select * From city Where name = 'Houston'
Select * From country Where code = 'USA'

Update country Set capital = (Select city.id From city Where name = 'Houston')
Where code = 'USA'

--Update country 
-- 2. Update the capital of the USA to Washington DC and the head of state
Select * From country Where code = 'USA'
Select * From city Where name = 'Washington'

Update country Set capital = (Select city.id From city Where name = 'Washington'), headofstate = 'Donald J. Trump'
Where code = 'USA'


-- DELETE

-- 1. Delete English as a spoken language in the USA'
Select * From countrylanguage Where countrycode = 'USA' AND language = 'English'

Delete From countrylanguage 
Where countrycode = 'USA' AND language = 'English'

-- 2. Delete all occurrences of the Klingon language 
Select * From countrylanguage Where language = 'Klingon'

Delete From countrylanguage
Where language = 'Klingon'

-- REFERENTIAL INTEGRITY

-- 1. Try just adding Elvish to the country language table.
Insert Into countrylanguage (language)
Values ('Elvish')

-- 2. Try inserting English as a spoken language in the country ZZZ. What happens?
Select * From country Where code = 'ZZZ'


Values ('English', 'ZZZ', 0, 100)

-- 3. Try deleting the country USA. What happens?
Select * From country Where code = 'USA'
Delete From country Where code = 'USA'

Insert Into country Values ('ZZZ', 'blah', 'Asia', 'blah', 1.0, 1, 1, 1.0, 1, 1, 'blah', 'blah', 'blah', 1, '11')
Select * From country Where code = 'ZZZ'
Delete From country Where code = 'ZZZ'

-- CONSTRAINTS
Select * From country 
Where code = 'USA'

Update country Set continent = 'North America'
Where code = 'USA'

-- 1. Try inserting English as a spoken language in the USA
Insert Into countrylanguage (countrycode, isofficial, percentage, language)
Values ('USA', 1, 86.1, 'English')

-- 2. Try again. What happens?
Insert Into countrylanguage (countrycode, isofficial, percentage, language)
Values ('USA', 1, 86.1, 'English')

-- 3. Let's relocate the USA to the continent - 'Outer Space'
Select * From country Where code = 'USA'

Update country Set continent = 'Outer Space'
Where code = 'USA'

-- How to view all of the constraints

SELECT * FROM INFORMATION_SCHEMA.TABLE_CONSTRAINTS
SELECT * FROM INFORMATION_SCHEMA.CONSTRAINT_COLUMN_USAGE
SELECT * FROM INFORMATION_SCHEMA.REFERENTIAL_CONSTRAINTS


-- TRANSACTIONS

-- 1. Try deleting all of the rows from the country language table and roll it back.

-- 2. Try updating all of the cities to be in the USA and roll it back

-- 3. Demonstrate two different SQL connections trying to access the same table where one happens to be inside of a transaction but hasn't committed yet.

BEGIN TRANSACTION
BEGIN TRY	

	--Select * From countrylanguage Where language = 'Elihazoun';
	Delete From countrylanguage Where language = 'Elihazoun';
	INSERT INTO countrylanguage (countrycode, language, isofficial, percentage)
	VALUES ('USA', 'Elihazoun', 0, .01);

	Select * From countrylanguage Where language = 'Elihazoun';

	--INSERT INTO countrylanguage (countrycode, language, isofficial, percentage)
	--VALUES ('USA', 'Elihazoun', 0, .01);

	Select * From countrylanguage Where language = 'Elihazoun';

	--INSERT INTO countrylanguage (countrycode, language)
	--VALUES ('GBR', 'Klingon');

	COMMIT TRANSACTION
END TRY

BEGIN CATCH
	ROLLBACK TRANSACTION
END CATCH