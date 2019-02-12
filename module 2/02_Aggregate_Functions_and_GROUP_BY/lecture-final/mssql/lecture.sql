-- ORDERING RESULTS

-- Populations of all countries in descending order
SELECT name, population FROM country ORDER BY population DESC;

--Names of countries and continents in ascending order
SELECT continent as 'Bob', name as 'Country', (population / surfacearea) as 'William'
FROM country 
WHERE continent In ('Asia', 'Africa')
ORDER BY 'William' ASC;

-- LIMITING RESULTS
-- The name and average life expectancy of the countries with the 10 highest life expectancies.

SELECT TOP 3 name, lifeexpectancy
FROM country
WHERE lifeexpectancy IS NOT NULL
ORDER BY lifeexpectancy ASC;

-- CONCATENATING OUTPUTS

-- The name & state of all cities in California, Oregon, or Washington.
-- "city, state", sorted by state then city

SELECT (name + ', ' + district) as 'Name and State'
FROM city
WHERE district='California' OR district='Oregon' OR district='Washington'
ORDER BY district, name;

-- AGGREGATE FUNCTIONS
-- Average Life Expectancy in the World
SELECT AVG(lifeexpectancy) as 'Avg Lifespan', MIN(lifeexpectancy) as 'Min Lifespan' FROM country;

SELECT governmentform, 
	   AVG(lifeexpectancy) as 'Avg Lifespan', 
	   name, continent, 
	   (AVG(gnp)/AVG(population)) as 'GNP per person'
FROM country
Where lifeexpectancy Is Not Null
Group By governmentform, name, continent
Order By 'GNP per person' Desc;

Select Top 1 name, lifeexpectancy
From country
Where lifeexpectancy IS NOT NULL
Order By lifeexpectancy ASC

-- Total population in Ohio
SELECT SUM(population) FROM city WHERE district = 'Ohio';

Select name From city WHERE district = 'Ohio';

-- The surface area of the smallest country in the world
SELECT MIN(surfacearea) FROM country;

-- The 10 largest countries in the world
SELECT TOP 10 * FROM country ORDER BY surfacearea DESC

-- The number of countries who declared independence in 1991
SELECT COUNT(*) FROM country Where indepyear = 1991;

-- GROUP BY
-- Count the number of countries where each language is spoken, order show them from most countries to least
select language, count(countrycode) as countries 
from countrylanguage 
group by language 
order by countries desc;

-- Average life expectancy of each continent ordered from highest to lowest
select continent, avg(lifeexpectancy) as avg_lifeexpectancy 
from country 
group by continent 
order by avg_lifeexpectancy desc;

Select count(language) as 'Language Count', countrycode From countrylanguage
Group By countrycode
Order By 'Language Count' Desc

Select language, isofficial From countrylanguage
Where countrycode = 'USA' and isofficial = 1

-- Exclude Antarctica from consideration for average life expectancy
select continent, avg(lifeexpectancy) as avg_lifeexpectancy from country where continent <> 'Antarctica' group by continent order by avg_lifeexpectancy desc;

-- Sum of the population of cities in each state in the USA ordered by state name
select district, sum(population) from city where countrycode='USA' group by district order by district;

-- The average population of cities in each state in the USA ordered by state name
select district, avg(population) from city where countrycode='USA' group by district order by district;

Select name From country
Where code
	In (Select countrycode From countrylanguage
		Where language = 'English')

-- SUBQUERIES
-- Find the names of cities under a given government leader 'Beatrix'
Select name From city
Where countrycode In (Select code From country Where headofstate = 'Beatrix')

-- Find the names of cities who's country they belong to has not declared independence yet
Select name From city 
Where countrycode In(Select code From country Where indepyear Is Null)

-- Additional samples
-- You may alias column and table names to provide more descriptive names
--SELECT name AS CityName FROM city AS cities;

-- Alias can also be used to create shorthand references, such c for city and co for country.
SELECT c.name, [country].name FROM city as c, country;

-- Ordering allows columns to be displayed in ascending order, or descending order (Look at Arlington)
--SELECT name, population FROM city WHERE countryCode='USA' ORDER BY name ASC, population DESC;

-- Limiting results allows rows to be returned in 'limited' clusters where LIMIT says how many, and an optional OFFSET specifies number of rows to skip
--SELECT name, population FROM city LIMIT 10 OFFSET 10;

-- Postgres has a number of string functions like SUBSTR. It also supports string concatenation, so we can build completed sentences if desired
--SELECT (name || ' is in the state of ' || district) AS city_state FROM city WHERE countryCode='USA';

-- Aggregate functions provide the ability to COUNT, SUM, AVG, and determine MIN and MAX. Only returns a single row of value(s).
--SELECT COUNT(name) AS city_count FROM city;  -- Counts the number of rows
--SELECT COUNT(population) FROM city;		-- Counts the number of rows
--SELECT SUM(population) AS total_city_population, COUNT(population) as number_of_cities, AVG(population) AS avergage_population FROM city;
SELECT MIN(population) AS smallest_population, MAX(population) AS largest_population FROM city;

-- GROUP BY clusters rows by a column value
SELECT  countrycode, MIN(population), MAX(population) FROM city GROUP BY countrycode;
