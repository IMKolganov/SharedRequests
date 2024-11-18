# README.md

## SharedRequests

`SharedRequests` — это библиотека моделей запросов и ответов для распределённых систем. Она упрощает обмен данными между микросервисами, предоставляя стандартные структуры запросов и ответов.

### Особенности

- Общие модели для запросов и ответов.
- Лёгкая интеграция в микросервисную архитектуру.
- Поддержка стандартных сценариев (например, временных меток, уникальных идентификаторов и флагов тестирования).

---

### Установка

Добавьте источник GitHub Packages в ваш проект.

1. Обновите или создайте файл `nuget.config` в корне вашего проекта:

```xml
<configuration>
  <packageSources>
    <add key="github" value="https://nuget.pkg.github.com/IMKolganov/index.json" />
  </packageSources>
</configuration>
```

2. Установите пакет через команду:
```bash
dotnet add package SharedRequests --version 1.0.0
```

### Публикация в GitHub Packages
Автоматическая публикация пакета осуществляется через GitHub Actions.

Пример workflow для публикации:
```bash
name: Publish NuGet Package

on:
  push:
    branches:
      - main

jobs:
  publish:
    runs-on: ubuntu-latest
    steps:
      - name: Checkout repository
        uses: actions/checkout@v3

      - name: Setup .NET
        uses: actions/setup-dotnet@v3
        with:
          dotnet-version: 8.0

      - name: Restore dependencies
        run: dotnet restore

      - name: Build project
        run: dotnet build --configuration Release

      - name: Pack NuGet package
        run: dotnet pack --configuration Release /p:PackageVersion=1.0.${{ github.run_number }}

      - name: Publish to GitHub Packages
        run: dotnet nuget push bin/Release/*.nupkg --source "https://nuget.pkg.github.com/${{ github.actor }}/index.json" --api-key "${{ secrets.GITHUB_PAT }}"

```
### Вклад
Если вы хотите внести изменения или добавить новые модели:

1. Сделайте форк репозитория.
2. Создайте новую ветку:
```bash
git checkout -b feature/my-new-feature
```
3. Внесите изменения и закоммитьте их:
```bash
git commit -m "Add my new feature"
```
Отправьте изменения:
```bash
git push origin feature/my-new-feature
```
5. Создайте Pull Request.

### Лицензия
Этот проект находится под лицензией MIT. Подробнее смотрите в файле LICENSE.
