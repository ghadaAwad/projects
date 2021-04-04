function Maps() {

    var myJason, x;
    myJason = {
        "name": [
            { "names": "Aqaba", "info": { "info": "Aqaba is located in the far south of Jordan on the Red Coast", "pop": "188,160" } },
            { "names": "Mafraq", "info": { "info": "It is located 80 km north of the capital", "pop": "580,000" } },
            { "names": "Amman", "info": { "info": "capital of Jordan", "pop": "4.008M" } },
            { "names": "Tafilah", "info": { "info": "In the southern sector of Jordan", "pop": "89,400" } },
            { "names": "Ma`an", "info": { "info": "It is located 216 km south of Amman", "pop": "121,400" } },
            { "names": "Irbid", "info": { "info": "It is located in the far north of Jordan", "pop": "1.77M" } },
            { "names": "Ajlun", "info": { "info": "It is located northwest of Jordan", "pop": "148,870" } },
            { "names": "Jarash", "info": { "info": "It is located northwest of Jordan", "pop": "237,000" } },
            { "names": "Balqa", "info": { "info": "It is 47 km from Amman", "pop": "428,000" } },
            { "names": "Madaba", "info": { "info": "It lies 33 km southwest of Amman", "pop": "84,600" } },
            { "names": "Karak", "info": { "info": "South Amman is 120 km away", "pop": "32,216" } },
            { "names": "Zarqa", "info": { "info": "It is located north-east of Amman, about 20 km away", "pop": "1.365M" } },
        ],
        "id": ["#JOR849", "#JOR850", "#JOR851", "#JOR852", "#JOR853", "#JOR854", "#JOR855", "#JOR856"
            , "#JOR857", "#JOR858", "#JOR859", "#JOR860"]

    };

    $(myJason.id[0])

    x = myJason.name[0].click(function () {
    $(".cities").html(x["names"]);
    $(".info_panel").html(x.info["info"] + '<br>' + '<br>' + "population" + " : " + x.info["pop"]);
    $(".info_panel").css("text-align", "center");
    $(".info_panel").css("background-color", "#FAEBD7");
    $(".info_panel").css("text-transform", "uppercase");
    });


    $(myJason.id[1]).click(function () {

        x = myJason.name[1];
        $(".cities").html(x["names"]);
        $(".info_panel").html(x.info["info"] + '<br>' + '<br>' + "population" + " : " + x.info["pop"]);
    });
    $(myJason.id[2]).click(function () {

        x = myJason.name[2];
        $(".cities").html(x["names"]);
        $(".info_panel").html(x.info["info"] + '<br>' + '<br>' + "population" + " : " + x.info["pop"]);
    });

    $(myJason.id[3]).click(function () {

        x = myJason.name[3];
        $(".cities").html(x["names"]);
        $(".info_panel").html(x.info["info"] + '<br>' + '<br>' + "population" + " : " + x.info["pop"]);
    });

    $(myJason.id[4]).click(function () {

        x = myJason.name[4];
        $(".cities").html(x["names"]);
        $(".info_panel").html(x.info["info"] + '<br>' + '<br>' + "population" + " : " + x.info["pop"]);
    });

    $(myJason.id[5]).click(function () {

        x = myJason.name[5];
        $(".cities").html(x["names"]);
        $(".info_panel").html(x.info["info"] + '<br>' + '<br>' + "population" + " : " + x.info["pop"]);
    });
    $(myJason.id[6]).click(function () {

        x = myJason.name[6];
        $(".cities").html(x["names"]);
        $(".info_panel").html(x.info["info"] + '<br>' + '<br>' + "population" + " : " + x.info["pop"]);
    });

    $(myJason.id[7]).click(function () {

        x = myJason.name[7];
        $(".cities").html(x["names"]);
        $(".info_panel").html(x.info["info"] + '<br>' + '<br>' + "population" + " : " + x.info["pop"]);
    });
    $(myJason.id[8]).click(function () {

        x = myJason.name[8];
        $(".cities").html(x["names"]);
        $(".info_panel").html(x.info["info"] + '<br>' + '<br>' + "population" + " : " + x.info["pop"]);
    });

    $(myJason.id[9]).click(function () {

        x = myJason.name[9];
        $(".cities").html(x["names"]);
        $(".info_panel").html(x.info["info"] + '<br>' + '<br>' + "population" + " : " + x.info["pop"]);
    });
    $(myJason.id[10]).click(function () {

        x = myJason.name[10];
        $(".cities").html(x["names"]);
        $(".info_panel").html(x.info["info"] + '<br>' + '<br>' + "population" + " : " + x.info["pop"]);
    });

    $(myJason.id[11]).click(function () {

        x = myJason.name[11];
        $(".cities").html(x["names"]);
        $(".info_panel").html(x.info["info"] + '<br>' + '<br>' + "population" + " : " + x.info["pop"]);
    });
    $(myJason.id[12]).click(function () {

        x = myJason.name[12];
        $(".cities").html(x["names"]);
        $(".info_panel").html(x.info["info"] + '<br>' + '<br>' + "population" + " : " + x.info["pop"]);
    });
}