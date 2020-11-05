Feature: Rechner
Rechner für trigonometrische Funktionen

@mytag
Scenario: sinus errechnen
	Given the number is Pi
	When the sinus of number
	Then the result should be 0

Scenario: cosinus errechnen
	Given the number is Pi
	When the cosinus of number
	Then the result should be -1

Scenario: tangens errechnen
	Given the number is Pi
	When the tangens of number
	Then the result should be 0