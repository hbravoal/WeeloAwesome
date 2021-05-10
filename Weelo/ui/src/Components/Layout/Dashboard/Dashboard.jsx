import React,{Fragment,useEffect} from 'react';
import Header from 'Components/Layout/Header';
import Footer from 'Components/Layout/Footer';
import Helmet from 'react-helmet';

const Dashboard = ({children,title}) => {
   
        if(process.env.PROD_KEY==='Production'){
            window.dataLayer = window.dataLayer || [];
            window.dataLayer.push({
            'event': 'Pageview',
            'pagePath': `${window.location.href}`,  // Poner la url de la página
            'pageTitle': `${title}` //some arbitrary name for the page/state // Poner el titulo de la página – articulo de blog
            });
        }else{
            console.log('No analytics. Only Production')
        }
    

    return (  
        <Fragment>
            <Helmet>
            <title>{title} </title>
            </Helmet>
            <Header/>
            {children}
            <Footer/>
        </Fragment>

    );
}
 
export default Dashboard;