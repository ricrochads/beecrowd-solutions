SELECT
    prod.name,
    prov.name,
    prod.price
FROM products prod
JOIN providers prov ON prod.id_providers = prov.id
JOIN categories cat ON prod.id_categories = cat.id
WHERE prod.price > 1000.00
AND cat.name = 'Super Luxury';