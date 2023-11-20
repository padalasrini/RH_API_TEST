Feature: Booking

Create a room booking and verify the booking is successful

@create_booking
Scenario Outline: create a room booking and verify the booking is successful
Given I create a room booking using the CreateBooking API
| firstname   | lastname   | totalprice   | depositpaid   | checkin   | checkout   | additionalneeds   |
| <FirstName> | <LastName> | <TotalPrice> | <DepositPaid> | <CheckIn> | <CheckOut> | <AdditionalNeeds> |
Then I verify the booking is successful using GetBooking API
Examples: 
| FirstName | LastName | TotalPrice | DepositPaid | CheckIn    | CheckOut   | AdditionalNeeds |
| Srini     | Padala   | 500        | True        | 2023-11-22 | 2023-11-24 | Breakfast       |
