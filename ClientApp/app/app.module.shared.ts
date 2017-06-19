import { NgModule, ErrorHandler } from '@angular/core';
import { RouterModule } from '@angular/router';

import { AppComponent } from './components/app/app.component'
import { NavMenuComponent } from './components/navmenu/navmenu.component';
import { HomeComponent } from './components/home/home.component';
import { FetchDataComponent } from './components/fetchdata/fetchdata.component';
import { CounterComponent } from './components/counter/counter.component';
import { ProfileComponent } from './components/profile/profile.component';
import { blogDetailComponent } from './components/blogDetail/blogDetail.component';
import { blogEditComponent } from './components/blogEdit/blogEdit.component';
import { blogNewComponent } from './components/blogNew/blogNew.component';

//import { FormsModule } from '@angular/forms';
//import { HttpModule } from '@angular/http';

//providers
import { BlogServcies } from './Service/blog.service';
import { DonationService } from './service/donation.service'

export const sharedConfig: NgModule = {
    bootstrap: [ AppComponent ],
    declarations: [
        AppComponent,
        NavMenuComponent,
        ProfileComponent,
        CounterComponent,
        FetchDataComponent,
        HomeComponent,
        blogDetailComponent,
        blogEditComponent,
        blogNewComponent
    ],
    providers: [
        BlogServcies,
        DonationService
    ],
    imports: [
        RouterModule.forRoot([
            { path: '', redirectTo: 'home', pathMatch: 'full' },
            { path: 'home', component: HomeComponent },
            { path: 'counter', component: CounterComponent },
            { path: 'fetch-data', component: FetchDataComponent },
            { path: 'profile', component: ProfileComponent },
            { path: 'blog-detail', component: blogDetailComponent },
            { path: 'edit/id', component: blogEditComponent },
            { path: 'new/id', component: blogNewComponent },
            { path: '**', redirectTo: 'home' }
        ])
    ]
};
