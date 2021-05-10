import React,{Fragment,useEffect} from 'react';
import Header from 'Components/Layout/Header';
import Footer from 'Components/Layout/Footer';

const Dashboard = ({children,title}) => {
   

    return (  
        <Fragment>
            <title>{title} </title>
            <Header/>
            {children}
            <Footer/>
        </Fragment>

    );
}
 
export default Dashboard;