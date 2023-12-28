Topic: 
Order management for an eyeglass store website

Description:
A system for managing orders for an eyeglass store, the system will allow you to order a product from the inventory

Entities:
customers
orders
products

Mapping routes to the customer:
Accepting all customers    Get('https://github.com/saraMolkhou/ObO.git')
Customer retrieval by ID   Get('https://github.com/saraMolkhou/ObO.git/{id}')
Adding a customer          PUT('https://github.com/saraMolkhou/ObO.git')
Update customer details    POST('https://github.com/saraMolkhou/ObO.git')

Mapping routes to the orders:
Accepting all orders      Get('https://github.com/saraMolkhou/ObO.git')
order retrieval by ID     Get('https://github.com/saraMolkhou/ObO.git/{id}')
Adding an order order     PUT('https://github.com/saraMolkhou/ObO.git')
Update an order details   POST('https://github.com/saraMolkhou/ObO.git')
Delete an order           DELETE('https://github.com/saraMolkhou/ObO.git')

Mapping routes to the products:
Accepting all products    Get('https://github.com/saraMolkhou/ObO.git')
product retrieval by ID   Get('https://github.com/saraMolkhou/ObO.git/{id}')
Adding a product          PUT('https://github.com/saraMolkhou/ObO.git')
Update product details    POST('https://github.com/saraMolkhou/ObO.git')
Delete a product          DELETE('https://github.com/saraMolkhou/ObO.git')
