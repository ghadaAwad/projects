function GeneratPieChart(Chart) {
        am4core.useTheme(am4themes_animated);
        var chart = am4core.create("chartdiv", am4charts.PieChart);
    chart.data = [{
        "country": "Amman",
        "litres": 4430700
    }, {
        "country": "Zarqa",
            "litres": 1509000
    }, {
        "country": "Arbid",
        "litres": 1957000
    }, {
        "country": "Ajlun",
        "litres": 194700
    }, {
        "country": "Kark",
        "litres": 350000
    }, {
        "country": "Aqaba",
        "litres": 208000
    
    }];

        // Add and configure Series
    var pieSeries = chart.series.push(new am4charts.PieSeries());
    pieSeries.dataFields.value = "litres";
    pieSeries.dataFields.category = "country";
    pieSeries.slices.template.stroke = am4core.color("#fff");
    pieSeries.slices.template.strokeWidth = 2;
    pieSeries.slices.template.strokeOpacity = 1;

    // This creates initial animation
    pieSeries.hiddenState.properties.opacity = 1;
    pieSeries.hiddenState.properties.endAngle = -90;
    pieSeries.hiddenState.properties.startAngle = -90;

    }
