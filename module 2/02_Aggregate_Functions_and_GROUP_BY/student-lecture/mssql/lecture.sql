-- ORDERING RESULTS

-- Populations of all countries in descending order

--Names of countries and continents in ascending order

-- LIMITING RESULTS
-- The name and average life expectancy of the countries with the 10 highest life expectancies.


-- CONCATENATING OUTPUTS

-- The name & state of all cities in California, Oregon, or Washington.
-- "city, state", sorted by state then city


-- AGGREGATE FUNCTIONS
-- Average Life Expectancy in the World

-- Total population in Ohio

-- The surface area of the smallest country in the world

-- The 10 largest countries in the world

-- The number of countries who declared independence in 1991

-- GROUP BY
-- Count the number of countries where each language is spoken, order show them from most countries to least

-- Average life expectancy of each continent ordered from highest to lowest

-- Exclude Antarctica from consideration for average life expectancy

-- Sum of the population of cities in each state in the USA ordered by state name

-- The average population of cities in each state in the USA ordered by state name

-- SUBQUERIES
-- Find the names of cities under a given government leader

-- Find the names of cities who's country they belong to has not declared independence yet

-- Additional samples
-- You may alias column and table names to provide more descriptive names
--SELECT name AS CityName FROM city AS cities;

-- Alias can also be used to create shorthand references, such c for city and co for country.
--SELECT c.name, co.name FROM city AS c, country AS co;

-- Ordering allows columns to be displayed in ascending order, or descending order (Look at Arlington)
--SELECT name, population FROM city WHERE countryCode='USA' ORDER BY name ASC, population DESC;

-- Limiting results allows rows to be returned in 'limited' clusters where LIMIT says how many, and an optional OFFSET specifies number of rows to skip
--SELECT name, population FROM city LIMIT 10 OFFSET 10;

-- Aggregate functions provide the ability to COUNT, SUM, AVG, and determine MIN and MAX. Only returns a single row of value(s).
--SELECT COUNT(name) AS city_count FROM city;  -- Counts the number of rows
--SELECT COUNT(population) FROM city;		-- Counts the number of rows
--SELECT SUM(population) AS total_city_population, COUNT(population) as number_of_cities, AVG(population) AS avergage_population FROM city;

-- GROUP BY clusters rows by a column value
