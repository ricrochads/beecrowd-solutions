SELECT
    cat.name AS name,
    SUM(prod.amount) AS sum
FROM products prod
JOIN categories cat ON prod.id_categories = cat.id
GROUP BY cat.name;