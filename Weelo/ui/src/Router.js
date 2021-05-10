import React, { Suspense, lazy } from 'react';
import { Route, BrowserRouter,Redirect, Switch   } from 'react-router-dom';
import BounceLoader from 'react-spinners/BounceLoader';
import LoadingOverlay from 'react-loading-overlay';
import Dashboard from 'Components/Layout/Dashboard';
import {IsAuth} from 'Services/authService';

const Login = lazy(() => import('Components/Login'));
const Home = lazy(() => import('Components/Home'));


 
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
                <Dashboard title="Login: Weelo">
                    <Login/>
                </Dashboard>
            </Route>
            
            <PrivateRoute path = '/Home' exact >
                <Dashboard title="Home: Weelo">
                        <Home/>
                </Dashboard>
            </PrivateRoute>

         
            <Route path = '/' exact >      
                <Dashboard title="Inicio: Weeelo">
                <Login/>
                </Dashboard>
            </Route>

            
        </Switch>
    </Suspense>
    </BrowserRouter>
    );
}
export default Router;