SELECT
    c.name,
    o.id
FROM orders o
JOIN customers c ON o.id_customers = c.id
WHERE EXTRACT(MONTH FROM o.orders_date) BETWEEN 1 AND 6; 