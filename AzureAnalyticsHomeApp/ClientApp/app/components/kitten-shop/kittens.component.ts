import { Component } from '@angular/core';
import { Http } from '@angular/http';

@Component({
    selector: 'kittens',
    template: require('./kittens.component.html'),
    styles: [require('./kittens.component.css')]
})
export class KittensComponent {
    public kittens: IKittens[]

    constructor(http: Http) {
        http.get('/api/kittens').subscribe(result => {
            this.kittens = result.json();
        });
    }
}

interface IKittens {
    name: string;
    id: string;
    category: string;
    description: string;
    price: number;
    image: string;
}
