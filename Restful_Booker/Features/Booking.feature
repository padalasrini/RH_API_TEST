Feature: Booking

Create a room booking and verify the booking is successful

@create_booking
Scenario Outline: create a room booking and verify the booking is successful
Given I create a room booking using the CreateBooking API
| firstname   | lastname   | totalprice   | depositpaid   | additionalneeds   |
| <FirstName> | <LastName> | <TotalPrice> | <DepositPaid> | <AdditionalNeeds> |
Then I verify the booking is successful using GetBooking API
Examples: 
| FirstName | LastName | TotalPrice | DepositPaid | AdditionalNeeds |
| Srini     | Padala   | 500        | True        | Breakfast       |
