# SqlIntro
Introduction to SQL

## Tasks

### Step 1
Fork and clone this repo

### Step 2
Expand the `ProductRepository` class

Navigate to the `ProductRepository.cs` and properly implement/complete all methods using raw SQL. When done, the `ProductRepository` class should be able to:

1. `SELECT` all products
1. `DELETE` a product with a particular `ProductId`
1. `UPDATE` a product's name with a particular `ProductId`
1. `INSERT` a new product

### Step 3
Create a `DapperProductRepository` class

Add a class called `DapperProductRepository` and enable the same methods implemented in the `ProductRepository` class, but avoid raw SQL in favor of [Dapper](https://github.com/StackExchange/Dapper). Make sure you implement:

1. `SELECT` all products
1. `DELETE` a product with a particular `ProductId`
1. `UPDATE` a product's name with a particular `ProductId`
1. `INSERT` a new product

### Step 4
Add 2 methods to your `DapperProductRepository` class

1. Add a method called `GetProductsWithReview` that performs an `INNER JOIN`
1. Add a method called `GetProductsAndReviews` that performs a `LEFT JOIN`

### Step 5
Make a pull request

**Good luck!**
