import {useContext} from 'react';
import {TOKEN,RESET_CLIENT} from 'Types';
import {TransactionContext} from 'Context/TransactionContext';


export const Save = (name,value) =>{
    localStorage.setItem(name,value);
}
export const Login =(token)=>{
    localStorage.setItem(TOKEN,token);
}

export const getToken =()=>{
    
    return localStorage.getItem(TOKEN);
}
export const IsAuth =()=>{
    if(localStorage.getItem(TOKEN)){
        // console.log('Si')
        return true;
    }else{
        // console.log('No')
        return false;
    }
}

export  const LogOut =()=>{
 
    localStorage.clear();
}

