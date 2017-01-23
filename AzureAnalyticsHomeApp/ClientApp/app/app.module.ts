import { NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';
import { UniversalModule } from 'angular2-universal';
//import { BrowserModule } from '@angular/platform-browser';
//import { MarkdownModule } from 'angular2-markdown';


import { AppComponent } from './components/app/app.component'
import { NavMenuComponent } from './components/navmenu/navmenu.component';

import { HomeComponent } from './components/home/home.component';
import { FetchDataComponent } from './components/fetchdata/fetchdata.component';
import { CounterComponent } from './components/counter/counter.component';
import { HelloWorldComponent } from './components/hello-world/helloworld.component';
import { KittensComponent } from './components/kitten-shop/kittens.component';
import { PowerBIExamplesComponent } from './components/powerbi-examples/pbi-index.component';

@NgModule({
    bootstrap: [ AppComponent ],
    declarations: [
        AppComponent,
        NavMenuComponent,
        HomeComponent,
        KittensComponent,
        PowerBIExamplesComponent,
        HelloWorldComponent,
        CounterComponent,
        FetchDataComponent
    ],
    imports: [
        UniversalModule, // Must be first import. This automatically imports BrowserModule, HttpModule, and JsonpModule too.
        //BrowserModule,
        //MarkdownModule,
        RouterModule.forRoot([
            { path: '', redirectTo: 'home', pathMatch: 'full' },
            { path: 'home', component: HomeComponent },
            { path: 'kitten-shop', component: KittensComponent },
            { path: 'pbi-index', component: PowerBIExamplesComponent },
            { path: 'hello-world', component: HelloWorldComponent },
            { path: 'counter', component: CounterComponent },
            { path: 'fetch-data', component: FetchDataComponent },
            { path: '**', redirectTo: 'home' }
        ])
    ]
})
export class AppModule {
}
