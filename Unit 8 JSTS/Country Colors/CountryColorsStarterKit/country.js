class Country {
    constructor(name, lang, greeting, colors, flagURL) {
        this.name = name;
        this.lang = lang;
        this.greeting = greeting;
        this.colors = colors;
        this.flagURL = flagURL;
    }
}
let usa = new Country("USA", "Murican", "Why Hello there world! Have some McDonalds", ["red", "white", "blue"], "us_flag.jpg");
let mexico = new Country("Mexico", "Spanish", "Hola mundo!", ["red", "white", "green"],"mexico_flag.jpg");
let algeria = new Country("Algeria", "Arabic and Berber", "Sup", ["blue", "yellow", "red"],"algeria_flag.jpg")

function SwitchCountry() {
    let input = document.getElementById("CountryList").value;;
    let country;

    if (input === "USA") {
        //set country to usa 
        country = usa;
        
    }
    else if (input === "Mexico") {
        country = mexico;
    }
    else if (input === "Algeria") {
        country = algeria;
    }
    document.getElementById("CountryName").innerText = country.name;
    document.getElementById("OfficialLanguage").innerText = country.lang;
    document.getElementById("HelloWorld").innerText = country.greeting;
    document.getElementById("Flag").src = country.flagURL;
    document.getElementById("Color1").style.backgroundColor = country.colors[0];
    document.getElementById("Color2").style.backgroundColor = country.colors[1];
    document.getElementById("Color3").style.backgroundColor = country.colors[2];

    //Image file types that are universal
    //JPG - rendering picture photo, detailed images
    //PNG - minimalist lightly detailed images
    //GIF - compressible file type, lowest quality for sitll images, animations/clips from videos
    //WebP - high resolution videos/animations
}

