# WalkingTec.Mvvm for aspnet core

WalkingTec.Mvvm Framework (WTM для краткости) - это среда быстрого развития, основанная на ядре .net. Поддержка Layui (отдельная передняя и задняя часть), React (раздельная передняя и задняя часть), VUE (отдельная передняя и задняя часть), встроенный генератор кода, максимизирующий эффективность разработки, является инструментом для эффективной разработки.

[![Coverage Status](https://coveralls.io/repos/github/dotnetcore/WTM/badge.svg?branch=master)](https://coveralls.io/github/dotnetcore/WTM?branch=master)
[![Member project of .NET Core Community](https://img.shields.io/badge/member%20project%20of-NCC-9e20c9.svg)](https://github.com/dotnetcore)
[![Gitter](https://badges.gitter.im/dotnetcore/WTM.svg)](https://gitter.im/dotnetcore/WTM?utm_source=badge&utm_medium=badge&utm_campaign=pr-badge)
[![GitHub license](https://img.shields.io/github/license/dotnetcore/WTM.svg)](https://github.com/dotnetcore/WTM/blob/master/LICENSE)
[![FOSSA Status](https://app.fossa.com/api/projects/git%2Bgithub.com%2Fdotnetcore%2FWTM.svg?type=shield)](https://app.fossa.com/projects/git%2Bgithub.com%2Fdotnetcore%2FWTM?ref=badge_shield)

## CI Build Status

| Platform | Build Server | SDK | Master Status  | Develop Status  |
| -------- | ------------ | ---- |---------|---------|
| Azure Pipelines |  Windows/Linux/OSX |  v2.2.300 | [![Build Status](https://dev.azure.com/vitowu/WTM/_apis/build/status/WTM-CI?branchName=master)](https://dev.azure.com/vitowu/WTM/_build/latest?definitionId=12&branchName=master) | [![Build Status](https://dev.azure.com/vitowu/WTM/_apis/build/status/WTM-CI?branchName=develop)](https://dev.azure.com/vitowu/WTM/_build/latest?definitionId=12&branchName=develop) |
| Azure Pipelines |  Windows/Linux/OSX |  v3.1.101 | [![Build Status](https://dev.azure.com/vitowu/WTM/_apis/build/status/WTM-CI-sdk_v3.1?branchName=feature/dotnet3)](https://dev.azure.com/vitowu/WTM/_build/latest?definitionId=28&branchName=master) | [![Build Status](https://dev.azure.com/vitowu/WTM/_apis/build/status/WTM-CI-sdk_v3.1?branchName=feature/dotnet3)](https://dev.azure.com/vitowu/WTM/_build/latest?definitionId=28&branchName=feature/dotnet3) |
| AppVeyor |  Windows/Linux |  v2.2.300 | - | - |
| Travis   | Linux/OSX |  v2.2.300 | - | - |

## Nuget Packages

Package name                              | Version                     | Downloads
------------------------------------------|-----------------------------|-------------
`WalkingTec.Mvvm.Core` | [![NuGet](https://img.shields.io/nuget/v/WalkingTec.Mvvm.Core.svg?style=flat-square&label=nuget)](https://www.nuget.org/packages/WalkingTec.Mvvm.Core/) | ![downloads](https://img.shields.io/nuget/dt/WalkingTec.Mvvm.Core.svg)
`WalkingTec.Mvvm.Mvc` | [![NuGet](https://img.shields.io/nuget/v/WalkingTec.Mvvm.Mvc.svg?style=flat-square&label=nuget)](https://www.nuget.org/packages/WalkingTec.Mvvm.Mvc/) | ![downloads](https://img.shields.io/nuget/dt/WalkingTec.Mvvm.Mvc.svg)
`WalkingTec.Mvvm.Mvc.Admin` | [![NuGet](https://img.shields.io/nuget/v/WalkingTec.Mvvm.Mvc.Admin.svg?style=flat-square&label=nuget)](https://www.nuget.org/packages/WalkingTec.Mvvm.Mvc.Admin/) | ![downloads](https://img.shields.io/nuget/dt/WalkingTec.Mvvm.Mvc.Admin.svg)
`WalkingTec.Mvvm.TagHelpers.LayUI` | [![NuGet](https://img.shields.io/nuget/v/WalkingTec.Mvvm.TagHelpers.LayUI.svg?style=flat-square&label=nuget)](https://www.nuget.org/packages/WalkingTec.Mvvm.TagHelpers.LayUI/) | ![downloads](https://img.shields.io/nuget/dt/WalkingTec.Mvvm.TagHelpers.LayUI.svg)


Kuàngjià zhǔyào tèdiǎn:

Kuàngjià tígōngle 4 lèi ViewModel, hángàile zhǔliú Web yìngyòng chéngxù chángjiàn de gōngnéng, fēnbié shì:
  BaseCRUDVM tígōng zuì chángjiàn de shùjù zēng shāngǎi de gōngnéng
  PagedListVM tígōng fēnyè lièbiǎo yǐjí dǎochū de gōngnéng
  ImportVM& TemplateVM tígōng shùjù dǎorù de gōngnéng
  BatchVM tígōng pīliàng cāozuò de gōngnéng

kuàngjià zì dài dàimǎ shēngchéng qì, kāifā gāoxiào kuàijié

kuàngjià tígōngle shù shí zhǒng qiántái kòngjiàn, bāokuòle Form,Grid,Panel,Dialog děng jīhū suǒyǒu chángyòng kòngjiàn, zài bù jìnxíng qiánhòu fēnlí de qíngkuàng xià, hòu duān rényuán yě kěyǐ qīngsōng xiě chū piàoliang de qiántái yèmiàn. Mùqián kuàngjià zhǐ zhīchí Layui zuòwéi qiánduān UI, hòuqí wǒmen huì zhīchí gèng duō.

Kuàngjià tígōngle nèizhì de yònghù, juésè, yònghù zǔ, shùjù quánxiàn, yèmiàn quánxiàn, càidān, rìzhì, yóujiàn, duǎnxìn, wénjiàn děng hòutái chángyòng guǎnlǐ gōngnéng

kuàngjià zhīchí dān diǎn dēnglù, ménhù Portal, fēnbù shì shùjùkù

kuàngjià tígōngle Redis,DFS děng hòutái kāifā chángyòng kù de jiǎnhuà cāozuò


kuàngjià tígōngle qiánhòu duān fēnlí hé bù fēnlí liǎng zhǒng móshì

| móshì | UI | zhuàngtài  |
|--------- |------------- |---------|
|bù fēnlí |LayUI |wěndìng |
|qiánhòu duān fēnlí |React |wěndìng |
|qiánhòu duān fēnlí |VUE |RTM|

WTM kuàngjià de qiánhòu duān fēnlí móshì tóngyàng kěyǐ shǐyòng dàimǎ shēngchéng qì tóngshí shēngchéng qiántái hé hòutái de dàimǎ, jí dà de jiàngdīle qiánhòu duān rényuán de gōutōng chéngběn, cóng běnzhí shàng tíshēngle kāifā xiàolǜ, ràng “fēnlí” bù zài fùzá huo ángguì.
Развернуть
608/5000
Основные особенности каркаса:

Фреймворк предоставляет четыре типа ViewModel, охватывающих общие функции основных веб-приложений, а именно:
  BaseCRUDVM предоставляет наиболее распространенные функции добавления, удаления и изменения данных
  PagedListVM предоставляет список подкачки и функцию экспорта
  ImportVM & TemplateVM предоставляет функцию импорта данных
  BatchVM предоставляет функции для пакетных операций

Фреймворк поставляется с генератором кода для эффективной и быстрой разработки

Среда предоставляет десятки внешних элементов управления, включая почти все обычно используемые элементы управления, такие как форма, сетка, панель и диалоговое окно. Не разделяя переднюю и заднюю часть, вспомогательный персонал может легко писать прекрасные внешние страницы. В настоящее время фреймворк поддерживает Layui только как интерфейсный интерфейс, и мы будем поддерживать его позже.

Каркас предоставляет встроенные функции фонового управления, такие как пользователи, роли, группы пользователей, права доступа к данным, права доступа к страницам, меню, журналы, электронные письма, SMS, файлы и т. Д.

Каркас поддерживает единый вход, портал портала, распределенную базу данных.

Среда обеспечивает упрощенные операции общих библиотек для фоновой разработки, таких как Redis, DFS и т. Д.


Каркас обеспечивает два режима разделения переднего и заднего конца и без разделения

| Режим | Интерфейс | Статус |
| --------- | ------------- | --------- |
| Не отделяйте | LayUI | Стабильный |
| Передний и задний разделитель | Реагировать | Стабильность |
| Передний и задний конец разделения | VUE | RTM |

Внешние и внутренние режимы разделения инфраструктуры WTM также могут использовать генератор кода для генерации внешнего и внутреннего кодов одновременно, что значительно снижает затраты на связь с внешним и внутренним персоналом, существенно повышает эффективность разработки и делает «разделение» более не сложным и дорогим ,



![WTM kuàngjià wēixìn gōngzhòng hào](./Doc/WalkingTec.Mvvm.Doc/wwwroot/imgs/gongzhonghao.Jpg)

guānzhù WTM wēixìn gōngzhòng hào, jíshí liǎojiě kuàngjià gēngxīn, gōngzhòng hào hái huì dìngqí fābù shìpín jiàochéng

kuàngjià wéndàng dìzhǐ:Http://Wtmdoc.Walkingtec.Cn

kuàngjià wèndá shèqū:Https://Community.Walkingtec.Cn

kuàngjià QQ jiāoliú qún:694148336

Nín kěyǐ diǎn zhèlǐ http://Wtmdoc.Walkingtec.Cn/setup zàixiàn yī jiàn shēngchéng WTM de xiàngmù, lìkè kāishǐ tǐyàn WTM zhīměi ~~~

****
mùqián wǒmen shì yīgè 7 rén tuánduì zài wéihù zhège xiàngmù, chéng zhēng gè lù C#,React,VUE gāoshǒu jiārù! Yǒuyì zhě kěyǐ jìn QQ qún jiā qún zhǔ xiáng liáo.
****


Zuìhòu gǎnxiè gèwèi lǎobǎn de zhīchí hé juānzèng, jùtǐ juānzèng xìnxī qǐng jiàn https://Wtmdoc.Walkingtec.Cn/#/Home/DonateList

rúguǒ WTM bāngzhù dàole nǐ, huānyíng zànzhù diǎn ràng wǒmen chíxù jiànzào gèng hǎo de lúnzi:
Развернуть
442/5000
! [Официальный аккаунт WTM Frame WeChat] (./doc/WalkingTec.Mvvm.Doc/wwwroot/imgs/gongzhonghao.jpg)

Обратите внимание на общедоступную учетную запись WTM WeChat, будьте в курсе обновлений фреймворка, а общедоступная учетная запись также будет регулярно публиковать видеоуроки

Рамочный адрес документа: http://wtmdoc.walkingtec.cn

Сообщество Q & A: https://community.walkingtec.cn

Framework QQ Exchange Group: 694148336

Вы можете нажать здесь http://wtmdoc.walkingtec.cn/setup, чтобы создать проект WTM одним щелчком мыши в режиме онлайн и сразу же начать испытывать всю прелесть WTM ~~~

****
В настоящее время мы работаем над проектом из 7 человек, и мы ищем экспертов C #, React и VUE, которые присоединятся к нам! Заинтересованные стороны могут войти в группу QQ плюс владелец группы, чтобы подробно поговорить.
****


Наконец, спасибо боссам за вашу поддержку и пожертвования. За конкретной информацией о пожертвованиях обращайтесь по адресу https://wtmdoc.walkingtec.cn/#/Home/DonateList.

Если WTM поможет вам, добро пожаловать в спонсорские пункты, чтобы продолжать создавать лучшие колеса:

<img src="./doc/WalkingTec.Mvvm.Doc/wwwroot/imgs/WTM-Ali.png"  height="300" width="300">

