import React, { Suspense, lazy } from 'react';
import { Route, BrowserRouter,Redirect, Switch   } from 'react-router-dom';
import { createHistory } from 'history';
import BounceLoader from 'react-spinners/BounceLoader';
import LoadingOverlay from 'react-loading-overlay';
import Dashboard from 'Components/Layout/Dashboard';
import {IsAuth} from 'Services/authService';

const Login = lazy(() => import('Components/Login'));
const Catalog = lazy(() => import('Components/Catalog'));
const ProductDetail = lazy(() => import('Components/Catalog/ProductDetail'));
const Blog = lazy(() => import('Components/Blog'));
const Detail = lazy(() => import('Components/Blog/Detail'));


 
 const PrivateRoute = ({component:Component,...rest})=>(
    
    IsAuth()  
    ?<Route {...rest} render={(props)=>(
         <Component {...props}> </Component>
    )}></Route>
    :<Redirect to="/Login"></Redirect>

    
)
const Router = () => {
    
    return ( 
    <BrowserRouter >
    <Suspense fallback={<LoadingOverlay active={true} spinner={<BounceLoader />}></LoadingOverlay>}>
        <Switch>
            <Route path = '/Login' exact >
                <Dashboard title="Login: Ingresar código - Aliado Financiero">
                    <Login/>
                </Dashboard>
            </Route>
            
            <PrivateRoute path = '/Catalog' exact >
                <Dashboard title="Catálogo: Catálogo - Aliado Financiero">
                        <Catalog/>
                </Dashboard>
            </PrivateRoute>

            <PrivateRoute path = '/ProductDetail/:id' exact >
                <Dashboard title="Detalle de catálogo: Detalle - Aliado Financiero">
                        <ProductDetail/>
                </Dashboard>
            </PrivateRoute>

            <Route path = '/Blog' exact >      
                <Dashboard title="Inicio: Inicio - Aliado Financiero">
                    <Blog/>
                </Dashboard>
            </Route>
            <Route path = '/BlogDetails/:id' exact >      
                <Dashboard title="Detalle de Blog: Blog - Aliado Financiero">
                    <Detail/>
                </Dashboard>
            </Route>
            <Route path = '/' exact >      
                <Dashboard title="Inicio: Inicio - Aliado Financiero">
                    <Blog/>
                </Dashboard>
            </Route>
{/*          
            <Route path = '/'
            exact component = { Blog }/> */}
            
        </Switch>
    </Suspense>
    </BrowserRouter>
    );
}
export default Router;