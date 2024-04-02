
[![GitHub Actions Status](https://github.com/MrLait/ShapeAreaCalculator/actions/workflows/CiDotNetApp.yml/badge.svg)](https://github.com/MrLait/ShapeAreaCalculator/actions)

#### Отклик на вакансию: [C# developer junior / middle (.net, full-stack / back-end)](https://hh.ru/vacancy/76709182?hhtmFrom=favorite_vacancy_list)
#### Задание первое
Напишите на C# библиотеку для поставки внешним клиентам, которая умеет вычислять площадь круга по радиусу и треугольника по трём сторонам. Дополнительно к работоспособности оценим:
- Юнит-тесты - **выполнено**
- Легкость добавления других фигур - **реализован паттерн Strategy**
- Вычисление площади фигуры без знания типа фигуры в compile-time - **реализован паттерн Strategy**
- Проверку на то, является ли треугольник прямоугольным - **реализовано**

#### Задание второе
В базе данных MS SQL Server есть продукты и категории. Одному продукту может соответствовать много категорий, в одной категории может быть много продуктов. Напишите SQL запрос для выбора всех пар «Имя продукта – Имя категории». Если у продукта нет категорий, то его имя все равно должно выводиться.

##### Ответ
```sql
SELECT Products.name, Categories.name
FROM Products
LEFT JOIN ProductCategory ON Product.id = ProductCategory.ProductId
LEFT JOIN Categories ON ProductCategory.CategoryId = Categories.id;
```
