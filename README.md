# Metro Fare Calculator Api
An api to calculate the total fare for a list of metro journeys provided. The calculation considers the followig:
1) Source and destination zone of the journey
2) Peak timings
3) Daily cap of fare
4) Weekly cap of fare

Please note the following assumptions:
1) The calculator engine is an api and it can be used by a web application or desktop application to do the necessary calculations.
2) No external database or storage mechanism is used. Instead an option to store the records in memory has been used.
3) No authorisation or authentication mechanism is built.
4) Test cases have been written only for the main controller (api) method.
5) There are 3 projects - a. Main api project 
                          b. A project for the contract used to pass information to the api 
                          c. Tests project
