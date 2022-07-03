import axios from "axios";
export default class GetPostItems{
    static async getall(){
        try{
            const response = await axios.get( 'https://localhost:7226/api/PostItem');
            
            return response.data;
        } catch (e) {
            console.log(e);
           
        }
       
    }
}