(function () {
    'use strict';

    angular.module('PetShopApp').controller('PetShopController', function () {
        this.pets = [
            {category: 'Dogs',
                animals: [{name: 'Samantha', img: 'http://www.explosion.com/wp-content/uploads/2014/12/813.jpg'},
                            {name: 'Heskyo', img: 'https://encrypted-tbn3.gstatic.com/images?q=tbn:ANd9GcSRW-U5OYBmVUcNGMkUDnNAI2ka9DIenlJoB8amaGh6Tqk8magSDA'},
                            {name: 'Margo', img: 'http://biologypop.com/wp-content/uploads/2014/11/dog2.jpg'},
                            {name: 'Anita', img: 'http://s.hswstatic.com/gif/bernese-mountain-dog.jpg'},
                            {name: 'Jaques', img: 'http://www.dogbreedplus.com/dog_breeds/images/canaan_dog.jpg'},
                            {name: 'Axel', img: 'http://i.telegraph.co.uk/multimedia/archive/02488/royal_mail_street__2488336b.jpg'}
                ]},
            {
                category: 'Bunnies',
                animals: [{ name: 'Flopsy', img: 'http://images4.fanpop.com/image/photos/19800000/baby-bunnies-baby-bunnies-19896709-1024-768.jpg' },
                            { name: 'Mopsy', img: 'http://4.bp.blogspot.com/-HTvSYzA-pO4/UgQb4Zh_u0I/AAAAAAAAEuI/XwhtogT_1tA/s1600/3+cute2.jpg' },
                            { name: 'Cottontail', img: 'http://www.studentsoftheworld.info/sites/animals/img/45407_White_Bunny.jpg' },
                            { name: 'Peter', img: 'http://www.cutebunnypictures.com/pictures/Cute_Bunny_Nomming_Flowers.jpg' }
                ]
            }
        ];
    });
})();