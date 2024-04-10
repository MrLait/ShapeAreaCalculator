
[![GitHub Actions Status](https://github.com/MrLait/ShapeAreaCalculator/actions/workflows/CiDotNetApp.yml/badge.svg)](https://github.com/MrLait/ShapeAreaCalculator/actions/workflows/CiDotNetApp.yml)

#### Отклик
#### Task 1
Напишите на C# библиотеку для поставки внешним клиентам, которая умеет вычислять площадь круга по радиусу и треугольника по трём сторонам. Дополнительно к работоспособности оценим:
- Юнит-тесты - **выполнено**
- Легкость добавления других фигур - **реализован паттерн Strategy**
- Вычисление площади фигуры без знания типа фигуры в compile-time - **реализован паттерн Strategy**
- Проверку на то, является ли треугольник прямоугольным - **реализовано**

#### Task 2
В базе данных MS SQL Server есть продукты и категории. Одному продукту может соответствовать много категорий, в одной категории может быть много продуктов. Напишите SQL запрос для выбора всех пар «Имя продукта – Имя категории». Если у продукта нет категорий, то его имя все равно должно выводиться.

##### Ответ
```sql
SELECT Products.name, Categories.name
FROM Products
LEFT JOIN ProductCategory ON Product.id = ProductCategory.ProductId
LEFT JOIN Categories ON ProductCategory.CategoryId = Categories.id;
```
1. Добавлена Clean - архитектура  + CQRS и Mediator.
2. MS Sql в докер контейнере