SELECT prod.name, prov.name
FROM products prod
JOIN categories cat ON prod.id_categories = cat.id
JOIN providers prov ON prod.id_providers = prov.id
WHERE cat.id = 6;