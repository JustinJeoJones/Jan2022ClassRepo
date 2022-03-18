export{}

//tallest mountain
interface Mountain {
    name:string;
    height:number;
}

let mountains:Mountain[] = [
    {
        name: "Kilimanjaro",
        height: 19341
    },
    {
        name:"Everest",
        height:29029
    },
    {
        name:"Denali",
        height:20310
    }
];

function findNameOfTallestMountain(MountainArray:Mountain[]):string{
    let result: Mountain = MountainArray[0];

    MountainArray.forEach((m:Mountain) =>{
        if(m.height > result.height){
            result = m;
        }
    });

    //reduce array method
    // let result = MountainArray.reduce(function(prev, current){
    //     return (current.height > prev.height)? current : prev
    // })

    return result.name;
}

let tallestName = findNameOfTallestMountain(mountains);
console.log(tallestName);

//Products
interface Product {
    name: string;
    price: number;
}

let products:Product[] = [
    {
        name:"Chips",
        price:2.50
    },
    {
        name:"Soda",
        price:1.99
    },
    {
        name:"Candy",
        price:1.00
    },
    {
        name:"Water",
        price:0.99
    },
];

function calcAverageProductPrice(productArray:Product[]):number{
    let total = 0;

    productArray.forEach(p => total += p.price);

    return total / productArray.length;
}

let avgPrice = calcAverageProductPrice(products);
console.log(avgPrice);

//Inventory
interface InventoryItem {
    product: Product;
    quantity: number;
}

let inventory:InventoryItem[] = [
    {
        product: {
            name: "Motor",
            price:10
        },
        quantity:10
    },
    {
        product: {
            name: "Sensor",
            price: 12.50
        },
        quantity:4
    },
    {
        product: {
            name: "LED",
            price: 1.00
        },
        quantity:20
    }
]

function calcInventoryValue(inventoryArray:InventoryItem[]):number{
    let total = 0;

    inventoryArray.forEach(i => total += i.product.price * i.quantity);

    return total;
}

let inventoryTotal = calcInventoryValue(inventory);
console.log(inventoryTotal);