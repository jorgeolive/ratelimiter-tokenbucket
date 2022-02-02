import http from 'k6/http';
import { sleep } from 'k6';
export const options = {
  vus: 2,
  duration: '20s',
};
export default function () {
  http.get('http://localhost:5177/weatherforecast');
  sleep(0.5);
}