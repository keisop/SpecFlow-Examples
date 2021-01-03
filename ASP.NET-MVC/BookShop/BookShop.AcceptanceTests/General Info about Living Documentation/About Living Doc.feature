Feature: About Living Doc

What we want to achieve with a Living Documentation
==============================================
This documentation should be understandable and readable by project team members as well as stakeholders.
This documentation lives through automation - meaning future code changes will break the corresponding automated scenario until it is updated as well.
For automation purposes we use the Gherkin language (Given, When, Then) with SpecFlow.

Not everything makes sense to automate (effort not worth the gained value).
In order to have all documentation in one spot (single source of truth) we will also document features which won't be automated in this living documentation.
The form could be just a scenario title describing the specification, a scenario title with decription or a fully described feature with steps.


What should a scenario describe
==============================================
Scenarios describe how the system should behave.
| Living Doc Item   | what it describes                                                              |
| :-------------------------- | :--------------------------                                          |
| Scenario title    | describes a specification                                                      |
| Given step        | describes the system state with which we begin (arrange)                       |
| When step         | describes the action which triggers the systems behavior (act)                 |
| Then step         | describes the behavior of the system or the system state after action (assert) |



Ramifications for manual testing
==============================================





