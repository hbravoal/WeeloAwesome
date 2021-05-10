import React,{Fragment,useState } from 'react';
import {useHistory} from 'react-router-dom';
import {IsAuth,LogOut} from 'Services/authService';


const Header = () => {    
    const [tooltipOpen, setTooltipOpen] = useState(false);

    const toggle = () => setTooltipOpen(!tooltipOpen);
    const history = useHistory();
    
 

    const handleNavigate = (e) => {
        e.preventDefault();
       
        history.push('/Login');
    }
    const handleSession = (e) => {
        e.preventDefault();
        LogOut();
         history.push('/Login');

    }
    
    return (
        <Fragment>
        {
             <section className="menu">
            <div className="container">
                <div className="row justify-content-between">
                <div className="col-auto col-img">
                    <h1>Weelo</h1>
                    </div>
                <div className="col-auto"><a className="button button-yellow" href="LogOut" onClick={handleSession}> <span>Cerrar sesión</span></a></div>
                </div>
                
                             
                
                
            </div>
        </section>
        }
        </Fragment>
        );
}
 
export default Header;