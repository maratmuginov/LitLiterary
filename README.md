# LitLiterary

## Project Description

Target audience: Public Libraries
Inventory Management System: Tracking states of inventory(books, audiobooks, DVDs, devices, etc).
Backend should be abstract enough to be for any target.
UI should specifically be for targeting public libraries.
“LitLibrary is an Inventory Management and Tracking Solution for Public Libraries.”

## Desired Libraries

.EF with SQLite
MVVM Project structure
DI (AutoFac/MS DependencyInjection)
Unit Testing (Moq)
Clients -> ASP.NET WebApi -> Database
SeriLog (grafana dashboard)
SMTP email client

## Project Requirements

Administrators should be able to add, modify, or delete inventory.
Administrators should be able to add, modify, or delete inventory policies (max checkout duration, fee rate).
Administrators should be able to add, modify, or delete Clients.
Clients should be able modify the state of an inventory asset (ex: checkout, checkin).
Clients should be able to add new (register) but not delete Members.
Members should be expirable, but not deleted.
Members should be able to be marked as a delinquent (preventing checkout).
Members that are delinquent should have a late-fee based on a specified return date
Members are notified via Email when they enter delinquent status.

## User Stories
Given an asset is checked out
When an Administrator reduces the max checkout duration policy
Only new transactions (asset state change) after the policy change date are affected.

Given an Administrator is logged in
When the Administrator executes a privileged action
Then log the transaction details referencing Administrator’s account.

Given a delinquent Member exists
When the Member returns a book (Client adds a new transaction)
Then Member is no longer delinquent, and Member’s fee amount is set to 0, and the asset’s owner is transferred back to the Library.

## Misc Notes/Definitions

Client = A librarian
Administory = A supervisor
Member = A library card holder/patron/customer
ISBN should not be PK, but rather properties of some asserts
